﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DotNetty.Transport.Channels
{
    using System;
    using System.Net;
    using System.Threading.Tasks;
    using DotNetty.Common.Concurrency;

    public class ChannelHandlerAdapter : IChannelHandler
    {
        internal bool Added;

        [Skip]
        public virtual void ChannelRegistered(IChannelHandlerContext context) => context.FireChannelRegistered();

        [Skip]
        public virtual void ChannelUnregistered(IChannelHandlerContext context) => context.FireChannelUnregistered();

        [Skip]
        public virtual void ChannelActive(IChannelHandlerContext context) => context.FireChannelActive();

        [Skip]
        public virtual void ChannelInactive(IChannelHandlerContext context) => context.FireChannelInactive();

        [Skip]
        public virtual void ChannelRead(IChannelHandlerContext context, object message) => context.FireChannelRead(message);

        [Skip]
        public virtual void ChannelReadComplete(IChannelHandlerContext context) => context.FireChannelReadComplete();

        [Skip]
        public virtual void ChannelWritabilityChanged(IChannelHandlerContext context) => context.FireChannelWritabilityChanged();

        [Skip]
        public virtual void HandlerAdded(IChannelHandlerContext context)
        {
        }

        [Skip]
        public virtual void HandlerRemoved(IChannelHandlerContext context)
        {
        }

        [Skip]
        public virtual void UserEventTriggered(IChannelHandlerContext context, object evt) => context.FireUserEventTriggered(evt);

        [Skip]
        public virtual void Write(IChannelHandlerContext context, object message, IPromise promise) => context.WriteAsync(message, promise);

        [Skip]
        public virtual void Flush(IChannelHandlerContext context) => context.Flush();

        [Skip]
        public virtual Task BindAsync(IChannelHandlerContext context, EndPoint localAddress) => context.BindAsync(localAddress);

        [Skip]
        public virtual Task ConnectAsync(IChannelHandlerContext context, EndPoint remoteAddress, EndPoint localAddress) => context.ConnectAsync(remoteAddress, localAddress);

        [Skip]
        public virtual void Disconnect(IChannelHandlerContext context, IPromise promise) => context.DisconnectAsync(promise);

        [Skip]
        public virtual void Close(IChannelHandlerContext context, IPromise promise) => context.CloseAsync(promise);

        [Skip]
        public virtual void ExceptionCaught(IChannelHandlerContext context, Exception exception) => context.FireExceptionCaught(exception);

        [Skip]
        public virtual void Deregister(IChannelHandlerContext context, IPromise promise) => context.DeregisterAsync(promise);

        [Skip]
        public virtual void Read(IChannelHandlerContext context) => context.Read();

        public virtual bool IsSharable => false;

        protected void EnsureNotSharable()
        {
            if (this.IsSharable)
            {
                ThrowHelper.ThrowInvalidOperationException_EnsureNotSharable(this);
            }
        }
    }
}