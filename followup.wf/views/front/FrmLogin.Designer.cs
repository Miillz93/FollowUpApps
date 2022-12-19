
namespace followup.wf.views.front;

partial class FrmLogin
{
    private Label LblUsername; 
    private Label  LblPassword;
    private Button BtnLogin;
    private TextBox TxtUsername;
    private TextBox TxtPassword;
    private Label LblForget;
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent(){
        // FrmLogin
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new (350, 750);
        this.Text = "Login Form";

        this.LblUsername = new();
        this.LblPassword = new ();
        this.TxtUsername = new();
        this.TxtPassword = new();
        this.LblForget = new();
        this.BtnLogin = new();
        this.SuspendLayout();

        //LblUsername
        LblUsername.Location = new (25,250);
        LblUsername.Size = new (300, 27);
        LblUsername.Name = "LblUsername";
        LblUsername.Text = "Username";
        LblUsername.TabIndex = 1;

        //TxtUsername
        TxtUsername.Location = new (25,275);
        TxtUsername.MinimumSize = new (300, 30);
        TxtUsername.TextAlign = HorizontalAlignment.Left;
        TxtUsername.Name = "TxtUsername";

        //LblPassword 
        LblPassword.Location = new (25,330);
        LblPassword.MinimumSize = new (200, 27);
        LblPassword.Name = "LblPassword";
        LblPassword.Text = "Password";

        //TxtPassword 
        this.TxtPassword.Location = new (25,355);
        this.TxtPassword.Size = new (300, 30);
        this.TxtPassword.Name = "TxtPassword";

        //LblForget 
        LblForget.Location = new (25,400);
        LblForget.Size = new (200, 27);
        LblForget.Name = "LblPassword";
        LblForget.Text = "Password Forget?";
        LblForget.ForeColor = Color.DarkBlue;
        
        //BtnLogin 
        BtnLogin.Location = new (25, 440);
        BtnLogin.Size = new (300, 60);
        BtnLogin.Name = "BtnLogin";
        BtnLogin.Text = "Login";
        BtnLogin.Click += new (this.BtnLogin_Click);

        //FrmLogin
        this.Controls.Add(LblUsername);
        this.Controls.Add(LblPassword);
        this.Controls.Add(TxtUsername);
        this.Controls.Add(TxtPassword);
        this.Controls.Add(LblForget);
        this.Controls.Add(BtnLogin);

        this.StartPosition = FormStartPosition.WindowsDefaultLocation;
        // this.StartPosition = FormStartPosition.CenterSCreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MinimizeBox = false;
        this.MaximizeBox = false;

        this.ResumeLayout(false);
        this.PerformLayout();

    }
    
}
