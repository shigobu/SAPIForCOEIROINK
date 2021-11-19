﻿using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFVvCommon
{
    public class Common
    {
        #region guid
        public const string guidString = "0C9A7CA1-E50F-433E-9546-CED09AD95665";
        /// <summary>
        /// TTSエンジンのcomで使用されるCLSID
        /// </summary>
        public static Guid CLSID { get; } = new Guid(guidString);

        /// <summary>
        /// レジストリ用Guid書式指定子
        /// </summary>
        /// <remarks>B書式指定子は中かっこ"{"で囲われる</remarks>
        public static string RegClsidFormatString { get; } = "B";

        #endregion

        #region レジストリ

        private const string tokensRegKey = @"SOFTWARE\Microsoft\Speech\Voices\Tokens\";
        private const string regClsid = "CLSID";

        /// <summary>
        /// Windowsのレジストリから、SAPIForVOICEVOXのスピーカー情報を削除します。
        /// </summary>
        public static void ClearStyleFromWindowsRegistry()
        {
            //SAPIForVOICEVOXのトークンを表すキーの列挙
            using (RegistryKey regTokensKey = Registry.LocalMachine.OpenSubKey(tokensRegKey, true))
            {
                string[] tokenNames = regTokensKey.GetSubKeyNames();
                foreach (string tokenName in tokenNames)
                {
                    using (RegistryKey tokenKey = regTokensKey.OpenSubKey(tokenName))
                    {
                        string clsid = (string)tokenKey.GetValue(regClsid);
                        if (clsid == CLSID.ToString(RegClsidFormatString))
                        {
                            regTokensKey.DeleteSubKeyTree(tokenName);
                        }
                    }
                }
            }
        }

        #endregion

        /// <summary>
        /// スタイルの並び替えを行います。
        /// </summary>
        /// <param name="styles">スタイル配列</param>
        /// <returns>並び替えされた配列</returns>
        public static IEnumerable<StyleBase> SortStyle(IEnumerable<StyleBase> styles)
        {
            return styles.OrderBy(x => x.Name, new StyleComparer()).ThenBy(x => x.ID);
        }
    }
}
