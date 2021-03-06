﻿using NDDD.Domain;
using NDDD.Domain.Exceptios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDDD.WinForm.Views
{
    public partial class BaseForm : Form
    {
        //Log4Netのおまじない
        private static log4net.ILog _logger =
            log4net.LogManager.GetLogger(
                System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BaseForm()
        {
            InitializeComponent();
            toolStripStatusLabel1.Visible = false;
#if DEBUG
            toolStripStatusLabel1.Visible = true;
#endif

            UserIdLabel.Text = Shared.LoginId;
        }
        protected void ExceptionProc(Exception ex)
        {
            _logger.Error(ex.Message, ex);
            MessageBoxIcon icon = MessageBoxIcon.Error;
            string caption = "エラー";
            var exceptionBase = ex as ExceptionBase;//as 型を変換 変換できなかったらnullになる
            if (exceptionBase != null)
            {
                if (exceptionBase.Kind == ExceptionBase.ExceptionKind.info)
                {
                    icon = MessageBoxIcon.Information;
                    caption = "情報";
                }
                else if (exceptionBase.Kind == ExceptionBase.ExceptionKind.Warinng)
                {
                    icon = MessageBoxIcon.Warning;
                    caption = "警告";
                }
            }
            MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, icon);
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logger.Info("open" + this.Name);
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            _logger.Info("close" + this.Name);
        }
    }
}
