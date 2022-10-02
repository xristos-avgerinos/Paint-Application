using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia2
{
    public partial class Form1 : Form
    {       
        public static int SLcount = 0,FScount = 0,Rcount = 0,Ecount = 0;//Αυτες οι μεταβλητες μετρανετο πληθος των σχηματων χρησιμοποιουνται στην εφαρμογη καθε φορα που ο χρηστης την τρεχει και στο τελος αποθηκευονται αυτα τα πληθη σε μια ΒΔ .Τις κανω public static για να ειναι ορατες στο Program.cs οπου κανω την αποθηκευση σε ΒΔ
        int timer1_tickcount = 1, timer2_tickcount = 1, timer3_tickcount = 1, timer4_tickcount = 1;
        Graphics g;
        Pen p,p_eraser;
        int x1, y1, fsX1, fsY1, cX1, cY1, tX1, tY1,erX1,erY1;//μηταβλητες που χρησιμευουν για τις συντεταγμενες του καθε σχηματος που επιλεγει ο χρηστης
        bool straightLines, freestyle, freestyleActivate, cycles, rectangles,eraser,eraserActivate;
        SoundPlayer player = new SoundPlayer("straightLines.wav");//καθε φορα που ο χρηστης σχεδιασει μια ευθεια γρααμμη η χρησιμοποιησει ελευθερο σχεδιο θα ακουγεται ο ηχος απο το straightLines.wav αρχειο που ειναι αποθηκευμενο στον Debug φακελο
        SoundPlayer player1 = new SoundPlayer("rectangle-ellipse.wav");//καθε φορα που ο χρηστης σχεδιασει ενα ορθογωνιο η ελλειψη θα ακουγεται ο ηχος απο το rectangle-ellipse.wav αρχειο που ειναι αποθηκευμενο στον Debug φακελο

        int count = 0; //μετραει το πληθος των φορων που καλειται η συναρτηση mouse move οταν κανουμε ελευθερο σχεδιο
        private void freestyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //μολις ο χρηστης πατησει το "κουμπι"(στην ουσια απο το toolstrip menu) ενεργοποιειται η επιλογη να κανουμε ελευθερο σχεδιο και θα απενεργοποιουνται ολες οι αλλες λειτουργιες σχεδιασης που εχουν ενεργοποιειθει προηγουμενως
            eraserActivate = false;
            rectangles = false;
            cycles = false;
            straightLines = false;
            freestyleActivate = true;
        }

        private void chooseColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //εδω δινεται η δυνατοτητα στο χρηστη να αλλαξει το χρωμα του pen   
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { 
                p.Color = colorDialog1.Color;
                chooseColorToolStripMenuItem.ForeColor = colorDialog1.Color;
            }
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void drawAFaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //μολις ο χρηστης πατησει το "κουμπι" Draw Human τοτε καθαριζεται αυτοματα ο πινακας και ενεργοποιειται ο timer 2
            g.Clear(panel1.BackColor);
            timer2.Enabled = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //σε καθε tick του timer2(καθε 500 ms) ζωγραφιζεται ενα σχημα στον πινακα αναλογα το timer2_tickcount και μετα απο 22 ticks θα εχει ζωγραφιστει αυτοματα ενας ανθρωπος
            switch (timer2_tickcount)
            {
                case 1:
                    g.DrawEllipse(p, 398, 98, 539-398, 214-98);
                    break;

                case 2:
                    g.DrawLine(p, 463, 150, 485, 160);
                    break;

                case 3:
                    g.DrawLine(p, 485, 160, 469, 165);
                    break;
                case 4:
                    g.DrawEllipse(p, 428, 133, 445 - 428, 145- 133);
                    break;
                case 5:
                    g.DrawEllipse(p, 494, 136, 510-494, 145-136);
                    break;
                case 6:
                    g.DrawLine(p, 424, 118, 452, 130);
                    break;
                case 7:
                    g.DrawLine(p, 520, 121, 488, 135);
                    break;
                case 8:
                    g.DrawRectangle(p, 447, 178, 494 - 447, 195 - 178);
                    break;
                case 9:
                    g.DrawLine(p, 447, 187, 493, 187);
                    break;
                case 10:
                    g.DrawLine(p, 449, 100, 323, 152);
                    break;
                case 11:
                    g.DrawLine(p, 449, 100, 349, 154);
                    break;
                case 12:
                    g.DrawLine(p, 449, 100, 368, 118);
                    break;
                case 13:
                    g.DrawLine(p, 449, 100, 430, 88);
                    break;
                case 14:
                    g.DrawLine(p, 510, 109, 623, 161);
                    break;
                case 15:
                    g.DrawLine(p, 497, 103, 568, 118);
                    break;
                case 16:
                    g.DrawLine(p, 519, 117, 611, 167);
                    break;
                case 17:
                    g.DrawLine(p, 477, 98, 501, 85);
                    break;
                case 18:
                    g.DrawLine(p, 468, 214, 468, 337);
                    break;
                case 19:
                    g.DrawLine(p, 414, 234, 468, 270);
                    break;
                case 20:
                    g.DrawLine(p, 468, 270, 532, 245);
                    break;
                case 21:
                    g.DrawLine(p, 468, 338, 413, 369);
                    break;
                case 22:
                    g.DrawLine(p, 468, 338, 523, 366);
                    break;
                default:
                    break;
            }
            timer2_tickcount++;
            if (timer2_tickcount > 22)
            {
                //μολις ζωγραφιστει ο ανθρωπος απενεργοποιειται ο timer2(σταματαει να μετραει) και το timer2_tickcount γινεται παλι 1 ωστε να μπορει να ξανα ζωγραφισει τον ανθρωπο ο χρηστης που χειριζεται την εφαρμογη
                timer2.Stop();
                timer2.Enabled = false;
                timer2_tickcount = 1;
            }
        }

        private void drawChristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //μολις ο χρηστης πατησει το "κουμπι" Draw Christmas Tree τοτε καθαριζεται αυτοματα ο πινακας και ενεργοποιειται ο timer 3
            g.Clear(panel1.BackColor);
            timer3.Enabled = true;
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //σε καθε tick του timer3(καθε 500 ms) ζωγραφιζεται ενα σχημα στον πινακα αναλογα το timer3_tickcount και μετα απο 20 ticks θα εχει ζωγραφιστει αυτοματα ενα χριστουγεννιατικο δεντρο
            switch (timer3_tickcount)
            {
                case 1:
                    g.DrawLine(p, 447, 81, 280, 234);
                    break;

                case 2:
                    g.DrawLine(p, 447, 81, 612, 232);
                    break;

                case 3:
                    g.DrawLine(p, 280, 234, 612, 232);
                    break;
                case 4:
                    g.DrawLine(p, 323, 195, 572, 195);
                    break;
                case 5:
                    g.DrawLine(p, 350, 171, 545, 171);
                    break;
                case 6:
                    g.DrawLine(p, 381, 142, 514, 142);
                    break;
                case 7:
                    g.DrawLine(p, 414, 111, 479, 111);
                    break;
                case 8:
                    g.DrawLine(p, 420, 235, 420, 321);
                    break;
                case 9:
                    g.DrawLine(p, 484, 235, 484,320);
                    break;
                case 10:
                    g.DrawLine(p, 448 ,80,416, 85);
                    break;
                case 11:
                    g.DrawLine(p, 416, 85, 439, 68);
                    break;
                case 12:
                    g.DrawLine(p, 439, 68, 416, 53);
                    break;
                case 13:
                    g.DrawLine(p, 416, 53, 438,51);
                    break;
                case 14:
                    g.DrawLine(p, 438, 51, 449, 28);
                    break;
                case 15:
                    g.DrawLine(p, 449, 28, 460, 51);
                    break;
                case 16:
                    g.DrawLine(p, 460, 51, 482, 55);
                    break;
                case 17:
                    g.DrawLine(p, 482, 55, 460, 68);
                    break;
                case 18:
                    g.DrawLine(p, 460, 68, 478, 87);
                    break;
                case 19:
                    g.DrawLine(p, 478, 87, 448, 80);
                    break;
                case 20:
                    g.DrawLine(p, 303, 326, 737, 322);
                    break;
                default:
                    break;
            }
            timer3_tickcount++;
            if (timer3_tickcount > 20)
            {
                //μολις ζωγραφιστει το δεντρο απενεργοποιειται ο timer3(σταματαει να μετραει) και το timer3_tickcount γινεται παλι 1 ωστε να μπορει να ξανα ζωγραφισει το δεντρο ο χρηστης που χειριζεται την εφαρμογη
                timer3.Stop();
                timer3.Enabled = false;
                timer3_tickcount = 1;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //σε καθε tick του timer4(καθε 500 ms) ζωγραφιζεται ενα σχημα στον πινακα αναλογα το timer4_tickcount και μετα απο 9 ticks θα εχει ζωγραφιστει αυτοματα ενα κουτι
            switch (timer4_tickcount)
            {
                case 1:
                    g.DrawLine(p, 392, 73, 557, 163);
                    break;

                case 2:
                    g.DrawLine(p, 557, 163, 367, 241);
                    break;

                case 3:
                    g.DrawLine(p, 367, 241, 215, 147);
                    break;
                case 4:
                    g.DrawLine(p, 215, 147, 392, 73);
                    break;
                case 5:
                    g.DrawLine(p, 367, 241, 382, 427);
                    break;
                case 6:
                    g.DrawLine(p, 382, 427, 548, 338);
                    break;
                case 7:
                    g.DrawLine(p, 548, 338, 557, 163);
                    break;
                case 8:
                    g.DrawLine(p, 215, 147, 242, 329);
                    break;
                case 9:
                    g.DrawLine(p, 242, 329, 381, 426);
                    break;
                default:
                    break;
            }
            timer4_tickcount++;
            if (timer4_tickcount > 9)
            {
                //μολις ζωγραφιστει το κουτι  απενεργοποιειται ο time4(σταματαει να μετραει) και το timer4_tickcount γινεται παλι 1 ωστε να μπορει να ξανα ζωγραφισει το κουτι ο χρηστης που χειριζεται την εφαρμογη
                timer4.Stop();
                timer4.Enabled = false;
                timer4_tickcount = 1;
            }
        }

        private void drawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //μολις ο χρηστης πατησει το "κουμπι" Draw Box τοτε καθαριζεται αυτοματα ο πινακας και ενεργοποιειται ο timer 4 
            g.Clear(panel1.BackColor);
            timer4.Enabled = true;
            timer4.Start();
        }

        private void drawHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //μολις ο χρηστης πατησει το "κουμπι" Draw House τοτε καθαριζεται αυτοματα ο πινακας και ενεργοποιηται ο timer 1
            g.Clear(panel1.BackColor);
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //σε καθε tick του timer1(καθε 500 ms) ζωγραφιζεται ενα σχημα στον πινακα αναλογα το timer1_tickcount και μετα απο 17 ticks θα εχει ζωγραφιστει αυτοματα ενα σπιτι
            switch (timer1_tickcount)
            {
                case 1:
                    g.DrawLine(p, 447, 81, 280, 234);
                    break;

                case 2:
                    g.DrawLine(p, 447, 81, 612, 232);
                    break;

                case 3:
                    g.DrawLine(p, 280, 234, 612, 232);
                    break;
                case 4:
                    g.DrawLine(p, 314, 234, 314, 445);
                    break;
                case 5:
                    g.DrawLine(p, 570, 234, 570, 443);
                    break;
                case 6:
                    g.DrawLine(p, 314, 445, 570, 443);
                    break;
                case 7:
                    g.DrawLine(p, 408, 306, 474, 306);
                    break;
                case 8:
                    g.DrawLine(p, 474, 308, 474, 400);
                    break;
                case 9:
                    g.DrawLine(p, 408, 306, 411, 400);
                    break;
                case 10:
                    g.DrawLine(p, 474, 400, 411, 400);
                    break;
                case 11:
                    g.DrawEllipse(p,418,358,5,5);
                    break;
                case 12:
                    g.DrawRectangle(p, 329, 254, 384 - 329, 309 - 254);
                    break;
                case 13:
                    g.DrawRectangle(p, 495, 254,  550 - 495, 313 - 254);
                    break;
                case 14:
                    g.DrawLine(p, 329, 274, 384, 274);
                    break;
                case 15:
                    g.DrawLine(p, 357, 274, 357, 309);
                    break;
                case 16:
                    g.DrawRectangle(p, 350, 408, 528 - 350, 417 - 408);
                    break;
                case 17:
                    g.DrawRectangle(p, 350, 424, 527 - 350, 433 - 424);
                    break;
                default:
                    break;
            }
            timer1_tickcount++;
            if (timer1_tickcount > 17)
            {
                //μολις ζωγραφιστει το σπιτι απενεργοποιειται ο time1(σταματαει να μετραει) και το timer1_tickcount γινεται παλι 1 ωστε να μπορει να ξανα ζωγραφισει το σπιτι ο χρηστης που χειριζεται την εφαρμογη
                timer1.Stop();
                timer1.Enabled = false;
                timer1_tickcount = 1;
            }
        }

        

        private void extraSmallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 1; //αλλαζουμε το παχος του pen
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 2;//αλλαζουμε το παχος του pen
        }

        private void eraserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //μολις ο χρηστης πατησει το "κουμπι" eraser ενεργοποιηται μια γομα που διαγραφει σημεια που δν μαρεσουν στο πινακα
            p_eraser.Color = panel1.BackColor;//στην ουσια το ξανα ζωγραφιζει το σημειο που σβηνει ο χρηστης με το back color του πινακα
            rectangles = false;
            cycles = false;
            straightLines = false;
            freestyleActivate = false;
            eraserActivate = true;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 3;//αλλαζουμε το παχος του pen
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 6;//αλλαζουμε το παχος του pen
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void clearCanvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //με το που πατησει το "κουμπι" clear canvas ο χρηστης τοτε καθαριζεται ολος ο πινακας (στην ουσια ξανα βαφεται ολοκληρος με το BackColor του)
            g.Clear(panel1.BackColor);
        }

        private void canvasColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //μολις ο χρηστης επιλεξει το "κουμπι" canvas color εμφανιζεται ενα colorDialog οπου ο χρηστης επιλεγει το χρωμα του πινακα που θελει
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
                canvasColorToolStripMenuItem.ForeColor = colorDialog1.Color;   
            }
        }

        private void extraLargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 9; //αλλαζουμε το παχος του pen
        }

        private void extraExtraLargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 13;//αλλαζουμε το παχος του pen
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // μολις ο χρηστης "αφησει" το ποντικι τοτε σχηματιζεται(δινοντας στην συναρτηση σχεδιασης σχηματος τις συντεταγμενες απο το mouse down και το mouse up ) το συγκεκριμενο σχημα που εχει επιλεχθει απο το χρηστη και αυξανεται το αντιστοιχο πληθος
            if (straightLines)
            {
                SLcount++;
                g.DrawLine(p, x1, y1, e.X, e.Y); //αυτο ειναι για να κανει ευθειες γραμμες
            }
            else if (freestyle)
            {
                FScount++;
                freestyle = false;
            }
            else if (cycles)
            {
                Ecount++;
                player1.Play();
                g.DrawEllipse(p, cX1, cY1, Math.Abs(e.X - cX1), Math.Abs(e.Y - cY1)); //αυτο ειναι για να κανει  κυκλους
            }
            else if (rectangles)
            {
                Rcount++;
                player1.Play();
                g.DrawRectangle(p, tX1, tY1, Math.Abs(e.X - tX1), Math.Abs(e.Y - tY1)); //αυτο ειναι για να κανει τετραγωνα
            }
            if(eraser)
                eraser = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (freestyle)
            {
                //καθε φορα που καλειται η συναρτηση mouse move απο το ελευθερο σχεδιο σχηματιζεται ενα πολυ μικρο ευθυγραμμο τμημα που δεν φαινεται με το ματι ωστε να δινεται η αισθηση οτι κανουμε ελευθερο σχεδιο.Το ιδιο ισχυει και με τη γομμα
                if (count == 100) //καθε 100 φορες που καλειται η συναρτηση mouse move οταν κανουμε ελευθερο σχεδιο θα ακουγεται ο ηχος απο τον player
                {
                    player.Play();
                    count = 0;
                }
                g.DrawLine(p, fsX1, fsY1, e.X, e.Y);
                fsX1 = e.X;
                fsY1 = e.Y;
                count++;
            }
            if (eraser)
            {
                g.DrawLine(p_eraser, erX1, erY1, e.X, e.Y);
                erX1 = e.X;
                erY1 = e.Y;
            }
               
        }
        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //σε καθε mouse down θα παιρνω τις συντεταγμενες που εγινε (αναλογα το σχημα)
            Cursor.Current = Cursors.Cross;//καθε φορα που θα γινεται mouse down θα αλλαζω το σχημα του κερσορα σε cross

            if (straightLines)
            {
                player.Play();
                x1 = e.X;
                y1 = e.Y;
            }
            else if (freestyleActivate)
            {
                player.Play();
                freestyle = true;
                fsX1 = e.X;
                fsY1 = e.Y;
            }
            else if (cycles)
            {
                cX1 = e.X;
                cY1 = e.Y;
            }
            else if (rectangles)
            {
                tX1 = e.X;
                tY1 = e.Y;
            }
            if (eraserActivate)
            {
                eraser = true;
                erX1 = e.X;
                erY1 = e.Y;
            }
        }

        private void straightLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //μολις ο χρηστης πατησει το "κουμπι"(στην ουσια απο το toolstrip menu) ενεργοποιειται η επιλογη να κανουμε ευθύγραμμα τμήματα και θα απενεργοποιουνται ολες οι αλλες λειτουργιες σχεδιασης που εχουν ενεργοποιειθει προηγουμενως
            eraserActivate = false;
            rectangles = false;
            cycles = false;
            freestyleActivate = false;
            straightLines = true;
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //μολις ο χρηστης πατησει το "κουμπι"(στην ουσια απο το toolstrip menu) ενεργοποιειται η επιλογη να κανουμε ελληψεις-κυκλους και θα απενεργοποιουνται ολες οι αλλες λειτουργιες σχεδιασης που εχουν ενεργοποιειθει προηγουμενως
            eraserActivate = false;
            rectangles = false;
            freestyleActivate = false;
            straightLines = false;
            cycles = true;
        }

        private void shapesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //μολις ο χρηστης πατησει το "κουμπι"(στην ουσια απο το toolstrip menu) ενεργοποιειται η επιλογη να κανουμε ορθογωνια και θα απενεργοποιουνται ολες οι αλλες λειτουργιες σχεδιασης που εχουν ενεργοποιειθει προηγουμενως
            eraserActivate = false;
            freestyleActivate = false;
            straightLines = false;
            cycles = false;
            rectangles = true;
        }

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            g = panel1.CreateGraphics();
            p = new Pen(Color.Black);
            p_eraser = new Pen(panel1.BackColor,11);
        }
        
    }
}
