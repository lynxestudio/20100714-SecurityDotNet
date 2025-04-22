using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityForm
{
    public partial class Form1 : Form
    {
        List<AuthenticationItem> comboBoxItems = new List<AuthenticationItem>();
        public Form1()
        {
            InitializeComponent();
            string[] items =
            {
                "Single Factor Authentication (SFA)",
                "Two-Factor Authentication (2FA)",
                "Multi-Factor Authentication (MFA)",
                "Password Authentication",
                "Passwordless Authentication",
                "Certificate-Based Authentication",
                "Adaptive Authentication",
                "SAML Authentication",
                "Biometric Authentication",
                "Behavioral Authentication",
                "Token Authentication",
                "Device Recognition",
                "Out-of-Band Authentication",
                "API Authentication",
                "Single Sign-On (SSO)",
                "CAPTCHAs",
                "Vault Authentication Methods",
                "Wireless Authentication Methods"

            };
            int i = 0;
            foreach (var s in items)
                comboBoxItems.Add(new AuthenticationItem(i++.ToString(), s));
            cbAuthenticationType.DataSource = comboBoxItems;
            cbAuthenticationType.DisplayMember = "Name";
            cbAuthenticationType.ValueMember = "Id";
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            WindowsIdentity wi = WindowsIdentity.GetCurrent();
            StringBuilder buf = new StringBuilder();
            buf.AppendLine("Login: " + wi.Name);
            buf.AppendLine("Is authenticated: " + wi.IsAuthenticated);
            buf.AppendLine("Authentication Type: "+ wi.AuthenticationType);
            buf.AppendLine("Is Anonymous/Guest/System: " +
            (wi.IsAnonymous ? "Anonymous" :
             (wi.IsGuest ? "Guest" :
              (wi.IsSystem ? "System" : "None"))));
            Info.Text = buf.ToString();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            GenericIdentity gi = new GenericIdentity(Username.Text, comboBoxItems[cbAuthenticationType.SelectedIndex].Name);
            StringBuilder buf = new StringBuilder();
            buf.AppendLine("Login: " + gi.Name.ToUpper());
            buf.AppendLine("Authentication Type: " + gi.AuthenticationType.ToUpper());
            buf.AppendLine("Is Authenticated: " + gi.IsAuthenticated);
            MessageBox.Show(buf.ToString(), "Output");
        }
    }
}
