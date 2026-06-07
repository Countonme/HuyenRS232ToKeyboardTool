using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuyenRS232ToKeyboardTool.Model
{
    public class SettingConfig
    {

        /// <summary>
        ///  channel 1 Index ##########################################
        /// <summary>
        /// 对应的Com 名称
        /// </summary>
        public string channel1ComName { get; set; }
        /// <summary>
        /// 1 Enable, 0 Disable
        /// </summary>
        public bool channel1Status { get; set; }

        /// <summary>
        ///  channel 2 Index ##########################################
        /// <summary>
        /// 对应的Com 名称
        /// </summary>
        public string channel2ComName { get; set; }

        /// <summary>
        /// 1 Enable, 0 Disable
        /// </summary> 
        public bool channel2Status { get; set; }

        /// <summary>
        ///  channel 3 Index ##########################################
        /// <summary>
        /// 对应的Com 名称
        /// </summary>
        public string channel3ComName { get; set; }

        /// <summary>
        /// 1 Enable, 0 Disable
        /// </summary> 
        public bool channel3Status { get; set; }



        /// <summary>
        ///  channel 4 Index ##########################################
        /// <summary>
        /// 对应的Com 名称
        /// </summary>
        public string channel4ComName { get; set; }

        /// <summary>
        /// 1 Enable, 0 Disable
        /// </summary> 
        public bool channel4Status { get; set; }


        /// <summary>
        ///  channel 5 Index ##########################################
        /// <summary>
        /// 对应的Com 名称
        /// </summary>
        public string channel5ComName { get; set; }

        /// <summary>
        /// 1 Enable, 0 Disable
        /// </summary> 
        public bool channel5Status { get; set; }

        /// <summary>
        ///  channel 6 Index #########################################
        /// <summary>
        /// 对应的Com 名称
        /// </summary>
        public string channel6ComName { get; set; }

        /// <summary>
        /// 1 Enable, 0 Disable
        /// </summary> 
        public bool channel6Status { get; set; }
        /// <summary>
        ///  channel 7 Index #########################################
        /// <summary>
        /// 对应的Com 名称
        /// </summary>
        public string channel7ComName { get; set; }

        /// <summary>
        /// 1 Enable, 0 Disable
        /// </summary> 
        public bool channel7Status { get; set; }
        /// <summary>
        ///  channel 8 Index #########################################
        /// <summary>
        /// 对应的Com 名称
        /// </summary>
        public string channel8ComName { get; set; }

        /// <summary>
        /// 1 Enable, 0 Disable
        /// </summary> 
        public bool channel8Status { get; set; }
        /// <summary>
        ///  channel 9 Index #########################################
        /// <summary>
        /// 对应的Com 名称
        /// </summary>
        public string channel9ComName { get; set; }

        /// <summary>
        /// 1 Enable, 0 Disable
        /// </summary> 
        public bool channel9Status { get; set; }
        /// <summary>
        ///  channel 9 Index #########################################
        /// <summary>
        /// 对应的Com 名称
        /// </summary>
        public string channel10ComName { get; set; }

        /// <summary>
        /// 1 Enable, 0 Disable
        /// </summary> 
        public bool channel10Status { get; set; }
        /// <summary>
        ///  channel 11 Index #########################################
        /// <summary>
        /// 对应的Com 名称
        /// </summary>
        public string channel11ComName { get; set; }

        /// <summary>
        /// 1 Enable, 0 Disable
        /// </summary> 
        public bool channel11Status { get; set; }
        /// <summary>
        ///  channel 12 Index #########################################
        /// <summary>
        /// 对应的Com 名称
        /// </summary>
        public string channel12ComName { get; set; }

        /// <summary>
        /// 1 Enable, 0 Disable
        /// </summary> 
        public bool channel12Status { get; set; }

        /// <summary>
        /// 读取超时
        /// </summary>
        public int readTimeout { get; set; } = 20;
        /// <summary>
        /// 目标窗体标题
        /// </summary>
        public string windownTitle { get; set; }
        /// <summary>
        /// 是否添加回车符
        /// </summary>
        public bool CarriageReturnFlag { get; set; }
        /// <summary>
        /// 是否添加换行符
        /// </summary>
        public bool LineFeedFlag { get; set; }
        /// <summary>
        /// 发送模式，
        /// </summary>
        public string sendMode { get; set; }
    }
}
