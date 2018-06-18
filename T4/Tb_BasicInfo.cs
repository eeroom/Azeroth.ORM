// Code generated by a template
using System;
using Azeroth.Nalu;
namespace T4
{
    public class Tb_BasicInfo
    {
        /// <summary>
        ///ID主键值
        /// </summary>
        public Guid BasicID {set;get;}
        /// <summary>
        ///基础名称
        /// </summary>
        [XString(200,true)]
        public String BasicName {set;get;}
        /// <summary>
        ///类别
        /// </summary>
        public Nullable<Int32> Classlayer {set;get;}
        /// <summary>
        ///创建时间
        /// </summary>
        public DateTime CreateTime {set;get;}
        /// <summary>
        ///是否删除
        /// </summary>
        public Boolean IsDel {set;get;}
        /// <summary>
        ///排序
        /// </summary>
        public Int32 Sort {set;get;}
        /// <summary>
        ///分类名称
        /// </summary>
        [XString(200,true)]
        public String ClassName {set;get;}
    }
}
// It's the end