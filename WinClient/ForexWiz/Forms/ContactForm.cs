using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using LeoStudio.ForexWiz.Entity;
using System.Reflection;

namespace LeoStudio.ForexWiz.Forms
{
    public partial class ContactForm : Office2007Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void buttonX_sendmail_Click(object sender, EventArgs e)
        {
            if (textBoxX_youemail.Text.Trim() == "")
            {
                MessageBoxEx.Show("请输入您的邮箱地址方便与你联系", "请输入邮箱地址", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBoxX_youemail.Focus();
                return;
            }
            else if (!textBoxX_youemail.Text.Contains("@"))
            {
                MessageBoxEx.Show("请输入正确邮箱地址", "请输入正确邮箱地址", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBoxX_youemail.Focus();
                return;
            }
            if (this.textBoxX_mailcontent.Text.Trim() == "")
            {
                MessageBoxEx.Show("请输入内容", "请输入内容", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBoxX_mailcontent.Focus();
                return;
            }

            try
            {
                Email.SendMail(GetSendTo(), Assembly.GetExecutingAssembly().GetName().Name + " 建议", GetConent());
                MessageBoxEx.Show("邮件发送成功", "发送成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "邮件发送失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        public string GetSendTo()
        {
            return this.textBoxX_youemail.Text.Trim();
        }

        public string GetConent()
        {
            return this.textBoxX_mailcontent.Text.Trim();
        }
    }
}
