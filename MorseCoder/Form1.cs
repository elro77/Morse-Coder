using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace MorseCoder
{
    public partial class Form1 : Form
    {
        private SoundPlayer[] soundPlayer= new SoundPlayer[26];
        private SoundPlayer soundy;
        public Form1()
        {
            InitializeComponent();
           // soundy = new SoundPlayer("A.wav");
            soundPlayer[0]= new SoundPlayer("A.wav");
            soundPlayer[1] = new SoundPlayer("B.wav");
            soundPlayer[2] = (new SoundPlayer("C.wav"));
            soundPlayer[3] = (new SoundPlayer("D.wav"));
            soundPlayer[4] = (new SoundPlayer("E.wav"));
            soundPlayer[5] = (new SoundPlayer("F.wav"));
            soundPlayer[6] = (new SoundPlayer("G.wav"));
            soundPlayer[7] = (new SoundPlayer("H.wav"));
            soundPlayer[8] = (new SoundPlayer("I.wav"));
            soundPlayer[9] = (new SoundPlayer("J.wav"));
            soundPlayer[10] = (new SoundPlayer("K.wav"));
            soundPlayer[11] = (new SoundPlayer("L.wav"));
            soundPlayer[12] = (new SoundPlayer("M.wav"));
            soundPlayer[13] = (new SoundPlayer("N.wav"));
            soundPlayer[14] = (new SoundPlayer("O.wav"));
            soundPlayer[15] = (new SoundPlayer("P.wav"));
            soundPlayer[16] = (new SoundPlayer("Q.wav"));
            soundPlayer[17] = (new SoundPlayer("R.wav"));
            soundPlayer[18] = (new SoundPlayer("S.wav"));
            soundPlayer[19] = (new SoundPlayer("T.wav"));
            soundPlayer[20] = (new SoundPlayer("U.wav"));
            soundPlayer[21] = (new SoundPlayer("V.wav"));
            soundPlayer[22] = (new SoundPlayer("W.wav"));
            soundPlayer[23] = (new SoundPlayer("X.wav"));
            soundPlayer[24] = (new SoundPlayer("Y.wav"));
            soundPlayer[25] = (new SoundPlayer("Z.wav"));
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            String str = "";
            char[] charArray = tbMessage.Text.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {             
                if (charArray[i] == ' ')
                    str+= "\r\n";
                else
                {
                    str +=  addCoded(charArray[i]);
                }        
            }
            tbCodedMessage.Text = str;
            tbCodedMessage.Update();
            for (int i=0;i<charArray.Length;i++)
            {
                if (charArray[i] == ' ')
                    Thread.Sleep(500);
                else
                {
                    soundPlayer.ElementAt(charArray[i] - 'a').PlaySync();
                }

               //soundy.PlaySync();        
            }

        }

        private String addCoded(char tav)
        {
            switch(tav)
            {
                case 'a':
                    return ".- ";
                case 'b':
                    return "-... ";
                case 'c':
                    return "-.-. ";
                case 'd':
                    return "-.. ";
                case 'e':
                    return ". ";
                case 'f':
                    return "..-. ";
                case 'g':
                    return "--. ";
                case 'h':
                    return ".... ";
                case 'i':
                    return ".. ";
                case 'j':
                    return ".--- ";
                case 'k':
                    return "-.- ";
                case 'l':
                    return ".-.. ";
                case 'm':
                    return "-- ";
                case 'n':
                    return "-. ";
                case 'o':
                    return "--- ";
                case 'p':
                    return ".--. ";
                case 'q':
                    return "--.- ";
                case 'r':
                    return ".-. ";
                case 's':
                    return "... ";
                case 't':
                    return "- ";
                case 'u':
                    return "..- ";
                case 'v':
                    return "...- ";
                case 'w':
                    return ".-- ";
                case 'x':
                    return "-..- ";
                case 'y':
                    return "-.-- ";
                case 'z':
                    return "--.. ";

            }
            return " ";
        }
    }
}
