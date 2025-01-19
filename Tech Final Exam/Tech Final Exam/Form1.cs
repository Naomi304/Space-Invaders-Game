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

namespace Exam
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        //Les Bruitages
        private SoundPlayer lasersound = new SoundPlayer(Tech_Final_Exam.Properties.Resources.LaserHit);//Quand l'utilisateur tape le "space bar" et "shoot" le laser
        private SoundPlayer explosion = new SoundPlayer(Tech_Final_Exam.Properties.Resources.LaserShoot);//Quand le laser touche le ufo
        private SoundPlayer MissedHit = new SoundPlayer(Tech_Final_Exam.Properties.Resources.boing_x);//Quand le laser touche un obsatcle
        private SoundPlayer Fin = new SoundPlayer(Tech_Final_Exam.Properties.Resources.Trumpet);//Quand le "score" = 5 et le jeux et fini

        //Variables pour les coordonées de L'ufo (X,Y)
        float ufoX;
        float ufoY;

        //Variable pour le Y coordonée du laser
        float laserY;

        //Variables pour les coordonées X et Y de obsatcle1 et obstacle2
        int obstacle1_Left_X;
        int obstacle1_Top_Y;

        int obstacle2_Left_X;
        int obstacle2_Top_Y = 188;// 188 est ou l'obstacle2 commence(le Y coordonée)

        //Le montant que l'ufo bouge a chaque tick du movetimer(Vitesse)
        float ufoX_Vitesse = 40;

        //Le montant que l'ufo bouge a chaque tick du movetimer(Vitesse)
        float laserY_Vitesse = 50;

        //Les montants que les obstacles bouge a chaque tick du movetimer (Les Vitesses)
        int obstacle1VitesseX = -25;
        int obstacle2VitesseX = 15;

        //score est ce qui va afficher le nombre de points de l'utilisateur, alors ca commence a 0
        int score = 0;

        //un bool qui commence la movement du laser quand l'utilisateur tape le "space bar"
        bool laserMoving = false;

        //un bool qui commence la movement des obstacles quand le score monte a 2 points
        bool CometMove = false;

        //Arrêter ou démarrer tout mouvement
        bool startRun = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                //Explication pour l'utilisateur
                MessageBox.Show("Bienvenue au jeux 'Attaque l'ufo!'\nVoici comment fonctionne le jeu.\nLe but est de frapper l’ovni avec le laser (Appuyez sur la barre d’espace pour actionner le laser).\nChaque fois que vous frappez l’ovni, vous obtenez un point.\nSi vous frappez l’ovni 5 fois, l’ovni est détruit et vous gagnez.\nCependant, une fois que vous obtenez 2 points, il y aura des obstacles sur votre chemin et si vous touchez un obstacle, vous perdez un point.\nAmusez-vous et bonne chance!");

                startRun = true;//Commence le movement de l'ufo

                //Prendre la position de départ de ces objets(X,Y)
                ufoX = ufo.Left;
                ufoY = ufo.Bottom;
                laserY = laser.Top;

                obstacle1_Left_X = obstacle1.Left;
                obstacle1_Top_Y = obstacle1.Top;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Space)
           {
                //Quand l'utilisateur tappe le "space bar"
                laserMoving = true;//Ce bool va commencer la movement du laser
                lasersound.Play();//Bruitage
            }
        }

        private void movetimer_Tick(object sender, EventArgs e)
        {
            //Des événments qui ce passent chaque tick du movetimer

            if (startRun == false)
            {
                //Pour que le messagebox vient seulement une fois

                return;//fait rien
            }

            ufoX += ufoX_Vitesse;//Ajouter le int de la variable ufoX_Vitesse au coordonée X de l'ufo

            if (ufoX > ClientSize.Width)
            {
                //Changer le coordonée de l'ufo quand l'ufo sort de l'écran

                ufoX = 0;//la nouvelle coordonée X
            }

            ufo.Left = (int)ufoX;//Bouge le laser à sa nouvelle coordonée

            if (laserMoving == true)
            {
                //Quand l'utilisateur tape le "space bar"

                laserY -= laserY_Vitesse;//Diminuer le int de la variable laserY_Vitesse au coordonée Y de le laser, alors que le laser bouge verticalement

                if (laserY < 0)
                {
                    //Changer le coordonée de le laser quand le laser sort de l'écran

                    laserY = 329;//La nouvelle coordonée Y
                    laserMoving = false;//arrête de bouger
                }

                laser.Top = (int)laserY;//Bouge le laser à sa nouvelle position
            }

            if (ufoY >= laserY)
            {
                //Quand le laser arrive au fond de l’ufo
                  
                if (ufo.Left <= laser.Right)
                {
                    //Lorsqu’il y a un chevauchement entre la gauche de l’ufo et la droite du laser

                    if (laser.Left <= ufo.Right)
                    {
                        //Lorsqu’il y a un chevauchement entre la droite de l’ufo et la gauche du laser

                        score = score + 1;//ajoute un point au score
                        pointsLabel.Text = score.ToString();//Convertir score a string
                        explosion.Play();//Bruitage
                        laserY = 329;//Remettre le laser où il a commencé
                        laserMoving = false;//laser arrête de bouger
                        laser.Top = (int)laserY;//laser reviens au point Y = 277
                    }
                }
            }

            if (score >= 2)
            {
                //Quand le score atteint 2

                CometMove = true;//Active le mouvement des obstacles
            }

            if (CometMove == true)
            {
                //Active le mouvement des obstacles

                //Ajouter le int des Variables de vitesses des obstacles au coordinee X des obstacles
                obstacle1_Left_X += obstacle1VitesseX;
                obstacle2_Left_X += obstacle2VitesseX;

                //Remettre les obstacle a leur points de départ si il vont hors écran
                if (obstacle1_Left_X + obstacle1.Width <= 0)
                {
                    obstacle1_Left_X = 731;//731 = point de départ
                }

                if (obstacle2_Left_X >= ClientSize.Width)
                {
                    obstacle2_Left_X = 0;//0 = point de départ
                }

                obstacle1.Left = obstacle1_Left_X;
                obstacle1.Top = obstacle1_Top_Y;

                obstacle2.Left = obstacle2_Left_X;
                obstacle2.Top = obstacle2_Top_Y;
            }

            if (obstacle1_Top_Y >= laserY)
            {
                //Quand le laser arrive au fond de l’obsatcle

                if (obstacle1.Left <= laser.Right)
                {
                    //Lorsqu’il y a un chevauchement entre la gauche de l’obsatcle et la droite du laser

                    if (laser.Left <= obstacle1.Right)
                    {
                        //Lorsqu’il y a un chevauchement entre la droite du laser et la gauche du obsatacle

                        score = score - 1;//Enlève un point du score
                        pointsLabel.Text = score.ToString();//Convertir le score en string
                        MissedHit.Play();//Bruitage
                        laserY = 329;//Point de départ de le laser
                        laserMoving = false;//le laser arrête de bouger
                        laser.Top = (int)laserY;//laser reviens au point Y = 277
                    }
                }
            }

            if (obstacle2_Top_Y >= laserY)
            {
                //Quand le laser arrive au fond de l’obsatcle

                if (obstacle2.Left <= laser.Left)
                {
                    //Lorsqu’il y a un chevauchement entre la gauche de l’obsatcle et la droite du laser

                    if (laser.Left <= obstacle2.Right)
                    {
                        //Lorsqu’il y a un chevauchement entre la droite du laser et la gauche du obsatacle

                        score = score - 1;//Enlève un point du score
                        pointsLabel.Text = score.ToString();//Convertir le score en string
                        MissedHit.Play();//Bruitage
                        laserY = 329;//Point de départ de le laser
                        laserMoving = false;//le laser arrête de bouger
                        laser.Top = (int)laserY;//laser revient au point Y = 277
                    }
                }
            }

            //Changer la couleur de l'arrire plan quand le score augmente
            if (score == 1)
            {
                BackColor = System.Drawing.Color.Pink;
            }
            if (score == 2)
            {
                BackColor = System.Drawing.Color.Green;
            }
            if (score == 3)
            {
                BackColor = System.Drawing.Color.Blue;
            }
            if (score == 4)
            {
                BackColor = System.Drawing.Color.Purple;
            }
            if (score == 5)
            {
                //Fin du jeux

                BackColor = System.Drawing.Color.Black;//Change de couleurs
                startRun = false;//Arrêter le mouvement
                Fin.Play();//Bruitage
                MessageBox.Show("Vous avez gagner! Félicitations!\nSi vous voulez continuer voici un autre ufo et le score va revenir a 0, sinon Au revoir!");//Message pour l'utilisateur
                score = 0;//recommencer le score
                ufoX = 0;//Remetre l'ufo au point de départ pour commencer un autre jeux
                pointsLabel.Text = score.ToString();//Convertir score à string
                startRun = true;//Commence le movement encore
            }
        }
    }
}