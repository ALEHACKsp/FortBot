using System;


using System.Drawing;
using System.Net;

using System.Windows.Forms;


namespace Loader
{
    public partial class FortBot : Form
    {
        public FortBot()
        {

           InitializeComponent();
      
        }

        private void FortBot_Load(object sender, EventArgs e)
        {
            how_to_use2.BringToFront();
            howtouse.ForeColor = System.Drawing.Color.Cyan;

            


        }

        private void howtouse_Click(object sender, EventArgs e)
        {
            sideslide.Height = howtouse.Height;
            sideslide.Height = howtouse.Height;
            sideslide.Top = howtouse.Top;
            how_to_use2.BringToFront();

            howtouse.ForeColor = System.Drawing.Color.Cyan;
            login.ForeColor = System.Drawing.Color.Black;
            maininfo.ForeColor = System.Drawing.Color.Black;
            extacc.ForeColor = System.Drawing.Color.Black;
            loginses.ForeColor = System.Drawing.Color.Black;
            verfiymeth.ForeColor = System.Drawing.Color.Black;
            info.ForeColor = System.Drawing.Color.Black;


        }

        private void login_Click(object sender, EventArgs e)
        {
            sideslide.Height = login.Height;
            sideslide.Top = login.Top;
            loginfrm2.BringToFront();

            howtouse.ForeColor = System.Drawing.Color.Black;
            login.ForeColor = System.Drawing.Color.Cyan;
            maininfo.ForeColor = System.Drawing.Color.Black;
            extacc.ForeColor = System.Drawing.Color.Black;
            loginses.ForeColor = System.Drawing.Color.Black;
            verfiymeth.ForeColor = System.Drawing.Color.Black;
            info.ForeColor = System.Drawing.Color.Black;
        }

        private void maininfo_Click(object sender, EventArgs e)
        {
            sideslide.Height = maininfo.Height;
            sideslide.Top = maininfo.Top;
            maininfo2.BringToFront();

            maininfo2.displayname.Text = Vars.displayyname;
            maininfo2.dispalychangenum.Text = "{   " + Vars.Displaychantm + "   }";
            maininfo2.email.Text = Vars.email;
            maininfo2.lastname.Text = Vars.lastnamee;
            maininfo2.firstname.Text = Vars.firstnamee;
            maininfo2.phonenum.Text = Vars.phonenum;
            maininfo2.cntry.Text = Vars.country;
            maininfo2.lastlogindate.Text = Vars.lastloginn;
            maininfo2.phonenum.Text = Vars.phonenum;
            maininfo2.acccreation.Text = Vars.cretaiondate;
            if (Vars.emailverffied == "true") {
                maininfo2.isverfied.ForeColor = System.Drawing.Color.Green;
            } else
            {
                maininfo2.isverfied.ForeColor = System.Drawing.Color.Red;

            }
            maininfo2.isverfied.Text = Vars.emailverffied;

            howtouse.ForeColor = System.Drawing.Color.Black;
            login.ForeColor = System.Drawing.Color.Black;
            maininfo.ForeColor = System.Drawing.Color.Cyan;
            extacc.ForeColor = System.Drawing.Color.Black;
            loginses.ForeColor = System.Drawing.Color.Black;
            verfiymeth.ForeColor = System.Drawing.Color.Black;
            info.ForeColor = System.Drawing.Color.Black;

        }

        private void extacc_Click(object sender, EventArgs e)
        {
            sideslide.Height = extacc.Height;
            sideslide.Top = extacc.Top;
            extranlacc2.BringToFront();

            if (Vars.done) { 
            if (Vars.psndate != "") { 
            extranlacc2.psn_date.Text = Vars.psndate;
            extranlacc2.psn_name.Text = Vars.psnname;
                } else
                {
                    extranlacc2.psn_date.Text = "null";
                    extranlacc2.psn_name.Text = "Not linked";
                }
            if (Vars.xb1date != "") { 
                extranlacc2.xbox_date.Text = Vars.xb1date;
            extranlacc2.xbox_name.Text = Vars.xb1name;
                } else
                {
                    extranlacc2.xbox_date.Text = "null";
                    extranlacc2.xbox_name.Text = "Not linked";
                }
                
                extranlacc2.nin_date.Text = Vars.nintindodate;
                extranlacc2.nin_name.Text = "No name";
           if (Vars.twitchdate != "") { 
            extranlacc2.twitch_date.Text = Vars.twitchdate;
            extranlacc2.twitch_name.Text = Vars.twitchname;
                }
                else
                {
                    extranlacc2.twitch_date.Text = "null";
                    extranlacc2.twitch_name.Text = "Not linked";
                }

            }

            howtouse.ForeColor = System.Drawing.Color.Black;
            login.ForeColor = System.Drawing.Color.Black;
            maininfo.ForeColor = System.Drawing.Color.Black;
            extacc.ForeColor = System.Drawing.Color.Cyan;
            loginses.ForeColor = System.Drawing.Color.Black;
            verfiymeth.ForeColor = System.Drawing.Color.Black;
            info.ForeColor = System.Drawing.Color.Black;

        }

        private void loginses_Click(object sender, EventArgs e)
        {
            sideslide.Height = loginses.Height;
            sideslide.Top = loginses.Top;
            loginsesfrm2.BringToFront();

            for (int i = 0; i < Vars.ips.Count; i++)
            {
                loginsesfrm2.listBox.Items.Add(Vars.ips[i]);
            }

            howtouse.ForeColor = System.Drawing.Color.Black;
            login.ForeColor = System.Drawing.Color.Black;
            maininfo.ForeColor = System.Drawing.Color.Black;
            extacc.ForeColor = System.Drawing.Color.Black;
            loginses.ForeColor = System.Drawing.Color.Cyan;
            verfiymeth.ForeColor = System.Drawing.Color.Black;
            info.ForeColor = System.Drawing.Color.Black;
        }

        private void verfiymeth_Click(object sender, EventArgs e)
        {
            sideslide.Height = verfiymeth.Height;
            sideslide.Top = verfiymeth.Top;
            verfiyfrm2.BringToFront();

            howtouse.ForeColor = System.Drawing.Color.Black;
            login.ForeColor = System.Drawing.Color.Black;
            maininfo.ForeColor = System.Drawing.Color.Black;
            extacc.ForeColor = System.Drawing.Color.Black;
            loginses.ForeColor = System.Drawing.Color.Black;
            verfiymeth.ForeColor = System.Drawing.Color.Cyan;
            info.ForeColor = System.Drawing.Color.Black;
        }

        private void info_Click(object sender, EventArgs e)
        {
            sideslide.Height = info.Height;
            sideslide.Top = info.Top;
            infofrm2.BringToFront();

            howtouse.ForeColor = System.Drawing.Color.Black;
            login.ForeColor = System.Drawing.Color.Black;
            maininfo.ForeColor = System.Drawing.Color.Black;
            extacc.ForeColor = System.Drawing.Color.Black;
            loginses.ForeColor = System.Drawing.Color.Black;
            verfiymeth.ForeColor = System.Drawing.Color.Black;
            info.ForeColor = System.Drawing.Color.Cyan;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private bool dragging;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            this.dragging = true;
            this.dragCursorPoint = Cursor.Position;
            this.dragFormPoint = base.Location;
        }

        
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragging)
            {
                Point pt = Point.Subtract(Cursor.Position, new Size(this.dragCursorPoint));
                base.Location = Point.Add(this.dragFormPoint, new Size(pt));
            }
        }

        

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            this.dragging = true;
            this.dragCursorPoint = Cursor.Position;
            this.dragFormPoint = base.Location;
        }


        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragging)
            {
                Point pt = Point.Subtract(Cursor.Position, new Size(this.dragCursorPoint));
                base.Location = Point.Add(this.dragFormPoint, new Size(pt));
            }
        }


        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }
    }
}
