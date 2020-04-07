﻿/*
 * Copyright (c) 2011-2014, Longxiang He <helongxiang@smeshlink.com>,
 * SmeshLink Technology Co.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY.
 * 
 * This file is part of the CoAP.NET, a CoAP framework in C#.
 * Please see README for more information.
 */

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Timers;
using CoAP.Log;
using CoAP.Net;

namespace CoAP.Deduplication
{
    class SweepDeduplicator : IDeduplicator
    {
        static readonly ILogger log = LogManager.GetLogger(typeof(SweepDeduplicator));

        private ConcurrentDictionary<Exchange.KeyID, Exchange> _incommingMessages
            = new ConcurrentDictionary<Exchange.KeyID, Exchange>();
        private Timer _timer;
        private ICoapConfig _config;

        public SweepDeduplicator(ICoapConfig config)
        {
            _config = config;
            _timer = new Timer(config.MarkAndSweepInterval);
            _timer.Elapsed += Sweep;
        }

        private void Sweep(Object sender, ElapsedEventArgs e)
        {
            if (log.IsDebugEnabled)
                log.Debug("Start Mark-And-Sweep with " + _incommingMessages.Count + " entries");

            DateTime oldestAllowed = DateTime.Now.AddMilliseconds(-_config.ExchangeLifetime);
            List<Exchange.KeyID> keysToRemove = new List<Exchange.KeyID>();
            foreach (KeyValuePair<Exchange.KeyID, Exchange> pair in _incommingMessages)
            {
                if (pair.Value.Timestamp < oldestAllowed)
                {
                    if (log.IsDebugEnabled)
                        log.Debug("Mark-And-Sweep removes " + pair.Key);
                    keysToRemove.Add(pair.Key);
                }
            }
            try
            {
                if (keysToRemove.Count > 0)
                {
                    Exchange ex;
                    foreach (Exchange.KeyID key in keysToRemove)
                    {
                        _incommingMessages.TryRemove(key, out ex);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <inheritdoc/>
        public void Start()
        {
            _timer.Start();
        }

        /// <inheritdoc/>
        public void Stop()
        {
            _timer.Stop();
            Clear();
        }

        /// <inheritdoc/>
        public void Clear()
        {
            _incommingMessages.Clear();
        }

        /// <inheritdoc/>
        public Exchange FindPrevious(Exchange.KeyID key, Exchange exchange)
        {
            Exchange prev = null;
            _incommingMessages.AddOrUpdate(key, exchange, (k, v) =>
            {
                prev = v;
                return exchange;
            });
            return prev;
        }

        /// <inheritdoc/>
        public Exchange Find(Exchange.KeyID key)
        {
            Exchange prev;
            _incommingMessages.TryGetValue(key, out prev);
            return prev;
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _timer.Dispose();
        }
    }
}
