﻿using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace WebProxy.Models
{
    public class RequestHead
    {
        /// <summary>
        /// 流水号
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// 请求地址
        /// </summary>
        public string RequestHost { get; set; }
        /// <summary>
        /// 请求时间
        /// </summary>
        public string RequestTime { get; set; }
        /// <summary>
        /// 指令名称
        /// </summary>
        public string Command { get; set; }
        /// <summary>
        /// 请求版本
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 系统
        /// </summary>
        public string System { get; set; }
        /// <summary>
        /// 渠道
        /// </summary>
        public string Channel { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 是否使用缓存
        /// </summary>
        public bool? UseCache { get; set; }   
        
        /// <summary>
        /// 路由发送给微服务的凭证
        /// </summary>
        public string Authorization { get; set; }
    }
}