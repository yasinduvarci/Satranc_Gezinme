using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satranc_Gezinme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int satir , sutun;
        int[,] dizi;
        int i = 0, j = 0;
        
        int snc = 1;
        string[] renk = new string[8];

        private void Tiklama(object sender, EventArgs e)
        {
            lblSkor.Visible = true;
            lblSkor.Text = snc.ToString();
            Button dinamikButon = (sender as Button);
            dinamikButon.Text = snc.ToString();
            dinamikButon.Enabled = false;
            string[] nsy;
            nsy = dinamikButon.Tag.ToString().Split(',');
            int str = Convert.ToInt32(nsy[0]); int stn = Convert.ToInt32(nsy[1]);
            foreach (var item in pnlEkran.Controls)
            {
                if (item is Button)
                    (item as Button).Enabled = false;  
            }

            if (snc != 1)
            {
                string[] ysn;
                for (int i = 0; i < 8; i++)
                {
                    if (renk[i] != "bos")
                    {
                        ysn = renk[i].Split(',');
                        int sr = Convert.ToInt32(ysn[0]); int sn = Convert.ToInt32(ysn[1]);
                        // dizi[sr, sn] = 0;
                        foreach (var item in pnlEkran.Controls)
                        {
                            if (item is Button)
                            {

                                string[] bol;
                                if ((item as Button).Tag != null)
                                {
                                    bol = (item as Button).Tag.ToString().Split(',');
                                    int srr = Convert.ToInt32(bol[0]); int snn = Convert.ToInt32(bol[1]);                                          
                                    if (sr == srr && sn == snn)
                                    {
                                        (item as Button).BackColor = Color.Azure;

                                        break;
                                    }

                                }

                            }

                        }
                    }
                   
                }
            }

            for (int i = 0; i < 8; i++)
            {
                renk[i] = "bos";
            }              
            try
            {
                if (dizi[str - 1, stn - 2] == -1)
                {
                    renk[0] = (str - 1).ToString() + "," + (stn - 2).ToString();
                }  
            }
            catch (Exception)
            {                  
                renk[0] = "bos";
            } 
            try
            {
                if (dizi[str + 1, stn - 2] == -1)
                {
                    renk[1] = (str + 1).ToString() + "," + (stn - 2).ToString();
                }  
            }
            catch (Exception)
            {
                renk[1] = "bos"; 
            }
            try
            {
                if (dizi[str + 2, stn - 1] == -1)
                {
                    renk[2] = (str + 2).ToString() + "," + (stn - 1).ToString();
                }  
            }
            catch (Exception)
            {
                renk[2] = "bos";
            }
            try
            {
                if (dizi[str + 2, stn + 1] == -1)
                {
                    renk[3] = (str + 2).ToString() + "," + (stn + 1).ToString();
                }   
            }
            catch (Exception)
            {
                renk[3] = "bos";
            }

            try
            {
                if (dizi[str - 1, stn + 2] == -1)
                {
                    renk[4] = (str - 1).ToString() + "," + (stn + 2).ToString();
                }  
            }
            catch (Exception)
            {
                renk[4] = "bos";

            }
            try
            {
                if (dizi[str + 1, stn + 2] == -1)
                {
                    renk[5] = (str + 1).ToString() + "," + (stn + 2).ToString();
                }   
            }
            catch (Exception)
            {   
                renk[5] = "bos";
            }

            try
            {
                if (dizi[str - 2, stn + 1] == -1)
                {
                    renk[6] = (str - 2).ToString() + "," + (stn + 1).ToString();
                }     
            }
            catch (Exception)
            {
                renk[6] = "bos";
            }
            try
            {
                if (dizi[str - 2, stn - 1] == -1)
                {
                    renk[7] = (str - 2).ToString() + "," + (stn - 1).ToString();
                }   
            }
            catch (Exception)
            {   
                renk[7] = "bos";
            }                
            dizi[str, stn] += 2;
            Renklendir();
            snc++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbYedi.Checked = true;
        }
         public void Renklendir()
        {
            string[] ysn; int game = 0;            
            for (int i = 0; i < 8; i++)
            {
                if (renk[i] != "bos")
                { 
                ysn = renk[i].Split(',');
                int sr = Convert.ToInt32(ysn[0]); int sn = Convert.ToInt32(ysn[1]);                    
                foreach (var item in pnlEkran.Controls)
                {
                    if (item is Button)
                    {
                        string[] bol;                            
                        if ((item as Button).Tag != null)
                        {
                            bol = (item as Button).Tag.ToString().Split(',');
                            int srr = Convert.ToInt32(bol[0]); int snn = Convert.ToInt32(bol[1]);                               
                            if (sr == srr && sn == snn)
                                {                                       
                                      (item as Button).Enabled = true;
                                      (item as Button).BackColor = Color.Blue;
                                      
                                }

                        }
                        }

                }
                }
                else
                {
                    game++;
                }                  
            }
            if (game == 8)
            {
                btnCiz.Text = "Yeniden Başla";
                lblSkor.Text = "OYUN BİTTİ SKOR = " + snc.ToString();
            }
                
               

        }
        public void Ciz()
        {
            for (i = 0; i < satir; i++)
            {
                for (j = 0; j < sutun; j++)
                {
                    int s = i, n = j;
                    Button btn = new Button();
                    if(dizi[i,j]==-1)
                    {
                        btn.BackColor = Color.Azure;
                        btn.Tag = s + "," + n;
                        btn.Name = i + "," + j;
                        btn.Text = "";
                        btn.Size = new Size(30, 30);
                        btn.Location = new Point(25 * j, 25 * i);
                        btn.Click += new EventHandler(Tiklama);
                        btn.FlatStyle = FlatStyle.Flat;
                        pnlEkran.Controls.Add(btn);
                        //this.Controls.Add(btn);
                    }
                }
            }
        }

        private void btnCiz_Click(object sender, EventArgs e)
        {
            if (pnlEkran.Enabled == true)
            {
                pnlEkran.Controls.Clear();
                snc = 1;

            }
                
                
             
            
            if (rdbDokuz.Checked == true)
            {
                satir = 9; sutun = 9;
                dizi = new int[satir,sutun];                
            }
            else if(rdbSekiz.Checked==true)
            {
                satir = 8; sutun = 8;
                dizi = new int[satir, sutun];
            }
            else if(rdbYedi.Checked==true)
            {
                satir = 7; sutun = 7;
                dizi = new int[satir, sutun];
              
            }
            for (i = 0; i < satir; i++)
            {
                for (j = 0; j < sutun; j++)
                {
                    dizi[i, j] = -1;
                }
            }

            Ciz();


        }
    }
}
