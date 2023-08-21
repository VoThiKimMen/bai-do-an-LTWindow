using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_VoThiKimMen.GUII
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TCĐH t1 = new TCĐH();
            t1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TTKH t2 = new TTKH();
            t2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormHoaDon hd = new FormHoaDon();
            hd.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            // Đặt đường dẫn đến tệp video bạn muốn phát
            string filePath = @"D:\Video\Video1.mp4";

            // Đảm bảo rằng WMP control đang khả dụng
            if (axWindowsMediaPlayer1 != null)
            {
                // Thiết lập đường dẫn tệp video cho WMP control
                axWindowsMediaPlayer1.URL = filePath;

                //// Đăng ký sự kiện PlayStateChange để xử lý sự kiện khi trạng thái phát thay đổi
                //axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;

                // Phát video
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Khi trạng thái phát thay đổi và trạng thái là MediaEnded (8), chạy lại video
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
