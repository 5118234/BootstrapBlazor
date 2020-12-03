﻿// **********************************
// 框架名称：BootstrapBlazor 
// 框架作者：Argo Zhang
// 开源地址：
// Gitee : https://gitee.com/LongbowEnterprise/BootstrapBlazor
// GitHub: https://github.com/ArgoZhang/BootstrapBlazor 
// 开源协议：LGPL-3.0 (https://gitee.com/LongbowEnterprise/BootstrapBlazor/blob/dev/LICENSE)
// **********************************

using System;

namespace BootstrapBlazor.Components
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class EditorOrderAttribute : Attribute
    {
        /// <summary>
        /// 获得 Order 属性
        /// </summary>
        public int Order { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        public EditorOrderAttribute(int order)
        {
            Order = order;
        }
    }
}
