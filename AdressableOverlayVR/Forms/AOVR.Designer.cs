using System.Drawing.Drawing2D;

namespace AdressableOverlayVR.Forms
{
    partial class AOVR
    {
        private void InitializeComponent()
        {
            int y1 = 40;
            PictureBox hmd = new PictureBox();
            PictureBox lcont = new PictureBox();
            PictureBox rcont = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)hmd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lcont).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rcont).BeginInit();
            SuspendLayout();
            // hmd
            hmd.Image = Properties.Resources.headset_status_png;
            hmd.Location = new Point(50, y1);
            hmd.Name = "hmd";
            hmd.Size = new Size(102, 64);
            hmd.TabIndex = 0;
            hmd.TabStop = false;
            // lcont
            lcont.Image = Properties.Resources.lcont;
            lcont.Location = new Point(200, y1);
            lcont.Name = "lcont";
            lcont.Size = new Size(58, 64);
            lcont.TabIndex = 1;
            lcont.TabStop = false;
            // rcont
            rcont.Image = Properties.Resources.rcont;
            rcont.Location = new Point(300, y1);
            rcont.Name = "rcont";
            rcont.Size = new Size(58, 64);
            rcont.TabIndex = 2;
            rcont.TabStop = false;
            // 
            // AOVR
            // 
            ClientSize = new Size(600, 480);
            Controls.Add(rcont);
            Controls.Add(lcont);
            Controls.Add(hmd);
            Name = "AOVR";
            ((System.ComponentModel.ISupportInitialize)hmd).EndInit();
            ((System.ComponentModel.ISupportInitialize)lcont).EndInit();
            ((System.ComponentModel.ISupportInitialize)rcont).EndInit();
            ResumeLayout(false);
        }
    }
}