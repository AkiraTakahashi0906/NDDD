﻿using NDDD.WinForm.BackgroundWorkers;
using NDDD.WinForm.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDDD.WinForm
{
    static class Program
    {
        //Log4Netのおまじない
        private static log4net.ILog _logger =
            log4net.LogManager.GetLogger(
                System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _logger.Debug("デバッグのログ");
            _logger.Info("インフォのログ");
            _logger.Warn("警告のログ");
            _logger.Error("エラーのログ");
            _logger.Fatal("致命的なログ");

            LatestTimer.Start();

            //Application.Run(new LatestView());
            Application.Run(new UserLoginView());
            //pplication.Run(new LoginView());
        }
    }
}
