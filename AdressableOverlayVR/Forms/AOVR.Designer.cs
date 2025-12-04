using System.Drawing.Drawing2D;

namespace AdressableOverlayVR.Forms
{
    partial class AOVR
    {
        private void InitializeComponent()
        {
            hmd = new PictureBox();
            lcont = new PictureBox();
            rcont = new PictureBox();
            search = new Button();
            bathmd = new Label();
            batlcont = new Label();
            batrcont = new Label();
            Playtime = new Label();
            fps = new Label();
            ((System.ComponentModel.ISupportInitialize)hmd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lcont).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rcont).BeginInit();
            SuspendLayout();
            // 
            // hmd
            // 
            hmd.Image = Properties.Resources.headset_status_png;
            hmd.Location = new Point(50, 40);
            hmd.Margin = new Padding(0);
            hmd.Name = "hmd";
            hmd.Size = new Size(102, 64);
            hmd.TabIndex = 0;
            hmd.TabStop = false;
            // 
            // lcont
            // 
            lcont.Image = Properties.Resources.lcont;
            lcont.Location = new Point(200, 40);
            lcont.Margin = new Padding(0);
            lcont.Name = "lcont";
            lcont.Size = new Size(58, 64);
            lcont.TabIndex = 1;
            lcont.TabStop = false;
            // 
            // rcont
            // 
            rcont.Image = Properties.Resources.rcont;
            rcont.Location = new Point(300, 40);
            rcont.Margin = new Padding(0);
            rcont.Name = "rcont";
            rcont.Size = new Size(58, 64);
            rcont.TabIndex = 2;
            rcont.TabStop = false;
            // 
            // search
            // 
            search.Location = new Point(30, 350);
            search.Name = "search";
            search.Size = new Size(350, 100);
            search.TabIndex = 3;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            // 
            // bathmd
            // 
            bathmd.AutoSize = true;
            bathmd.Location = new Point(50, 40);
            bathmd.Name = "bathmd";
            bathmd.Size = new Size(73, 32);
            bathmd.TabIndex = 4;
            bathmd.Text = "000%";
            // 
            // batlcont
            // 
            batlcont.AutoSize = true;
            batlcont.Location = new Point(200, 40);
            batlcont.Name = "batlcont";
            batlcont.Size = new Size(73, 32);
            batlcont.TabIndex = 5;
            batlcont.Text = "000%";
            // 
            // batrcont
            // 
            batrcont.AutoSize = true;
            batrcont.Location = new Point(300, 40);
            batrcont.Name = "batrcont";
            batrcont.Size = new Size(73, 32);
            batrcont.TabIndex = 6;
            batrcont.Text = "000%";
            // 
            // Playtime
            // 
            Playtime.AutoSize = true;
            Playtime.Location = new Point(9, 132);
            Playtime.Name = "Playtime";
            Playtime.Size = new Size(231, 32);
            Playtime.TabIndex = 7;
            Playtime.Text = "Playtime: 00h 00min";
            // 
            // fps
            // 
            fps.AutoSize = true;
            fps.Location = new Point(9, 182);
            fps.Name = "fps";
            fps.Size = new Size(88, 32);
            fps.TabIndex = 8;
            fps.Text = "fps: ---";
            // 
            // AOVR
            // 
            ClientSize = new Size(400, 480);
            Controls.Add(fps);
            Controls.Add(Playtime);
            Controls.Add(batrcont);
            Controls.Add(batlcont);
            Controls.Add(bathmd);
            Controls.Add(search);
            Controls.Add(rcont);
            Controls.Add(lcont);
            Controls.Add(hmd);
            Name = "AOVR";
            ((System.ComponentModel.ISupportInitialize)hmd).EndInit();
            ((System.ComponentModel.ISupportInitialize)lcont).EndInit();
            ((System.ComponentModel.ISupportInitialize)rcont).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox hmd;
        private PictureBox lcont;
        private PictureBox rcont;
        private Button search;
        private Label bathmd;
        private Label batlcont;
        private Label batrcont;
        private Panel panel1;
        private Label Playtime;
        private Label fps;
    }
}