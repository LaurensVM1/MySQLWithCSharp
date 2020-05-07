using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace delegateDemo
{
    //1. wat is een delegate?
    // Een delegate is een soort van pointer die wijst naar een method.
    // Een delegate wordt gebruikt om methods als argument door te geven aan andere methods.
    delegate void toonLijstDelegate(List<int> mijnLijst,Form1 frm);

    public partial class Form1 : Form
    {
        //2. Waarvoor worden onderstaande lijsten gebruikt?
        // De randomGetallenLijst wordt gebruikt om random getallen op te slaan
        // De List ChildForms is een lijst van aangemaakte forms
        readonly List<int> randomGetallenLijst = new List<int>();
        public List<Form1> ChildForms = new List<Form1>();

        //3. Leg uit wat een static variabele is? 
        // Wanneer een variabele als statisch wordt gedeclareerd, wordt 1 enkele kopie van de variabele gemaakt en 
        // gedeeld met alle objecten op het klassenniveau.
        static int formNummer = 1;
        const int MAX_RANDOMGETALLEN = 10;
        const int MAX_RANDOMWAARDE = 100;

        public Form1()
        {
            InitializeComponent();

            //4. De static int formNummer wordt gebruikt om elke form een volgnummer te geven.
            //Deze staat in de klasse gedefinieerd als 'static int formNummer = 1;'.
            //Hoe komt het dat ondanks die in die declaratie '... = 1' staat elke form toch een 
            //oplopend nummer krijgt? Leg dit grondig uit.
            // Zodat je weet of het een parent form of child form is, dit nummer is een kenteken voor hoeveel forms er zijn en welke dit zijn.
            this.Name = "Form"+formNummer.ToString();
            Form1.formNummer++;

            btnVulLijstMetRandomGetallen.Text = "Vul List<int> met " + MAX_RANDOMGETALLEN.ToString() + " randomgetallen";
            
            //5. Wat is het effect van het onderstaande statement op de Form?
            // Het zet de naam van het klasseobject (in dit geval form1) als tekst, dus de tekst die bovenop de form staat:Form1, Form2, ...
            this.Text = this.Name;
        }

        //6. Wanneer je op de button 'btnMaakNieuweChildForm' klikt dan wordt er een
        //nieuwe childform aangemaakt. Bestudeer grondig de onderstaande method en 
        //omschrijf - in woorden of met een diagram - de stappen die worden
        //uitgevoerd bij het aanmaken van een childform.
        //Leg uit wat de functie is van 'mijnAndereForm', 'OuderForm' en 'ChildForms'. 
        //Geef aan of het over objecten of attributen gaat. Leg uit van welke klasse ze
        //zijn of bij welk object ze horen en omschrijf waarvoor ze gebruikt worden.

        // STAPPEN:
        // Eerst wordt er nieuw object gemaakt van de klasse Form
        // Hierna wordt het al openstaande form als ouderform gezet
        // Dan wordt dit nieuwe aangemaakte form in de lijst van childforms gezet
        // Deze nieuwe form wordt dan getoond door show.
        private void BtnMaakNieuweChildForm_Click(object sender, EventArgs e)
        {
            Form1 mijnAndereForm = new Form1(); 
            mijnAndereForm.OuderForm = this;
            ChildForms.Add(mijnAndereForm);
            mijnAndereForm.Show();
        }

        //7. Onderstaande method genereert een aantal randomgetallen. Hoeveel getallen 
        //worden er gegenereerd? Wat is het grootste randomgetal dat kan worden 
        //gegenereerd?
        // Het aantal getallen dat wordt gegenereerd wordt vastgelegd door de constante MAX_RANDOMGETALLEN wat nu op 10 staat
        // Het grootste getal dat gegenereerd kan worden wordt vastgelegd door de constante MAX_RANDOMWAARDE wat nu op 100 staat,
        // 100 kan niet gegenereerd worden
        private void BtnVulLijstMetRandomGetallen_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            randomGetallenLijst.Clear();

            for (int i=0; i<MAX_RANDOMGETALLEN; i++)
            {
                randomGetallenLijst.Add(random.Next(0, MAX_RANDOMWAARDE));
            }

            foreach (int i in randomGetallenLijst)
            {
                tbLogText.Text += i + "  ";
            }
            tbLogText.Text += Environment.NewLine;
        }

        //8. Waarvoor wordt het property OuderForm gebruikt?
        // Om aan te duiden of de form een parent of child is, de volgende functie is een getter/setter
        private Form1 ouderForm;

        public Form1 OuderForm
        {
            get { return ouderForm; } 
            set { ouderForm = value; }
        }

        //9. Je kan de naam van een parent van een childform tonen. Leg uit hoe de onderstaande 
        //method dit realiseert.
        // Als het ouderform niets bevat, dus geen child forms in zich heeft (wordt gedaan met null) dan toont hij dat dit een bronform is
        // anders geeft hij de naam van de parent.
        private void BtnToonParentNaam_Click(object sender, EventArgs e)
        {
            if (ouderForm != null) 
            {
                MessageBox.Show("De parent van dit child is "+ ouderForm.Name, "aangemaakt vanaf...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dit is een bronform", "aangemaakt vanaf...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //10. Je kan de namen van alle childs van een parent tonen. Leg uit hoe de onderstaande 
        //method dit realiseert.
        // Als er formobjecten in de childform list zitten dan toont hij de naam van alle childforms van die parent anders zijn er geen childforms van die parent
        private void BtnToonChildForms_Click(object sender, EventArgs e)
        {
            if (ChildForms.Count>0)
            {
                foreach (Form1 f in ChildForms)
                {
                    tbLogText.Text +="Childform : " + f.Name + Environment.NewLine;
                }
            }
            else
            {
                tbLogText.Text += "Deze parent heeft geen childforms"+Environment.NewLine;
            }
        }

        //11. Onderstaande method toont de random getallen van een child op zijn parent.
        //Dit lijkt een éénvoudige routine, maar schijn bedriegt. Niet elke form heeft immers een parent. 
        //Hoe wordt er bijgehouden of het form een parentform heeft? 
        //Door de property ouderForm
        //Bovendien kan een childform niet zomaar op een parentform gaan
        //schrijven. Er is nog zoiets als thread-safety...Om op een veilige manier data van 
        //een childform naar een parentform te schrijven wordt er gebruik gemaakt van delegates.
        //We hebben dit mechanisme al in de les gezien. Omschrijf voor deze toepassing hoe het
        //delegate-mechanisme zorgt dat data veilig van een childform naar een parentform wordt geschreven

        // De delegate functie wordt aangeroepen, eerst is er een invoke nodig, in dit stuk van het if-statement wordt de functie nog eens aangeroepen,
        // hierna is het veilig om te schrijven naar een andere form, de functie wordt voor een 2de keer uitgevoerd nu is er geen invoke nodig,
        // dus voert de functie het 2de deel van het IF-statement uit wat de getallen schrijft naar de andere form.
        private void BtnToonGetallenOpParent_Click(object sender, EventArgs e)
        {
            if  (ouderForm!=null)
            {
                ToonRandomGetallenOpForm(randomGetallenLijst,ouderForm);
            }
            else
            {
                MessageBox.Show("Dit is een bronform. Het heeft geen ouderform...");
            }
        }

        private void ToonRandomGetallenOpForm(List<int> randomGetallen, Form1 frm)
        {           
            if (frm.tbLogText.InvokeRequired)
            {
                var d = new toonLijstDelegate(ToonRandomGetallenOpForm);
                frm.tbLogText.Invoke(d, new object[] { randomGetallenLijst, frm });
            }
            else
            {
                foreach (int i in randomGetallen)
                {
                    frm.tbLogText.Text += i+"  ";
                }
                frm.tbLogText.Text += Environment.NewLine;
            }
        }

        //12. Onderstaande method toont de random getallen van een parent op al zijn children.
        //Dit lijkt weerom een éénvoudige routine, maar schijn bedriegt. 
        //Ook hier moet er rekening gehouden worden met thread-safety...
        //Om op een veilige manier data van een parentform naar een childform te schrijven wordt er 
        //gebruik gemaakt van delegates. We hebben dit mechanisme al in de les gezien.
        //Omschrijf voor deze toepassing hoe het delegate mechanisme zorgt dat data veilig 
        //van de parentform naar de childforms wordt geschreven.
        // De delegate functie wordt aangeroepen en er gebeurt hetzelfde als het antwoord op vraag 11 juist wordt er naar een child form geschreven.
        // ANTWOORD VRAAG 11: 
        // De delegate functie wordt aangeroepen, eerst is er een invoke nodig, in dit stuk van het if-statement wordt de functie nog eens aangeroepen,
        // hierna is het veilig om te schrijven naar een andere form, de functie wordt voor een 2de keer uitgevoerd nu is er geen invoke nodig,
        // dus voert de functie het 2de deel van het IF-statement uit wat de getallen schrijft naar de andere form.

        private void BtnToonGetallenOpChild_Click(object sender, EventArgs e)
        {
                foreach(Form1 f in ChildForms)
                {
                    ToonRandomGetallenOpForm(randomGetallenLijst, f);
                }
        }

        //13. Onderstaande method sluit een form. Dat is iets wat met zorg moet gebeuren. Een form kan 
        //immers een parentform en childforms hebben. Referenties daarnaar wil je niet zomaar
        //levend laten...
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Onderstaande lus wordt uitgevoerd wanneer je een willekeurige form sluit.
            //Wat wordt er in deze lus gedaan? 
            //Eerst worden al de child forms van de form die je wil sluiten gesloten.

            //Om dit te testen start je de code op. Form1 opent. Je maakt een Kinder-form Form2 aan. 
            //Vervolgens maak je van Form2 een kinder-form Form3 aan. Sluit dan (met 'x') Form1. 
            //Wat stel je vast?
            // De childforms worden eerst gesloten dan pas de form die je wil sluiten
            //
            //Voer vervolgens onderstaande test uit: maak eerst forms aan volgens onderstaand schema.
            //De -> geeft de parent-child relatie aan. Sluit vervolgens form2. Wat stel je vast?
            //form1 -> form2
            //form1 -> form3
            //form2 -> form4
            //form2 -> form5
            //form4 -> form6
            //form4 -> form7
            // Eerst worden alle childs van form4 gesloten dan form 5 en 4, dan pas form 2
            for (var i = 0; i < ChildForms.Count; i++)
            {
                MessageBox.Show(ChildForms[i].Name.ToString() + " wordt gesloten ");
                ChildForms[i].OuderForm = null;
                ChildForms[i].Close();
                //uncomment het onderstaande if-statement eens, run de code en maak van een parentform 
                //een viertal childforms aan. Wat gebeurt er wanneer je de parent verwijderd?
                // Na het sluiten van 2 forms komt er een argument null exception error.
                //Hoe kan je ervoor zorgen dat jouw toepassing toch gecontroleerd kan worden gesloten?
                // Door deze if er niet in te zetten, of de if laten controleren of er geen fout is gebeurd in de Childforms lijst
                // Dus eigenlijk kijken of er nog steeds childforms in de lijst zitten zonder een error te krijgen.
                if (i == 2) throw (new ArgumentNullException());
            }

            ChildForms.Clear();

            //Waarom is bij het sluiten van een Form het onderstaande if-statement
            //noodzakelijk? 
            // Dit verwijdert alle forms definitief, het sluiten van een form is niet genoeg.       
            //Om dit te testen start je de code op. Form1 opent. Je maakt een Kinder-form Form2 aan. 
            //Vervolgens maak je van Form2 een kinder-form Form3 aan. Sluit dan (met 'x') Form2. 
            //Wat stel je vast?
            // De forms 'bestaan' nog altijd in het programma, de forms bestaan dus nog altijd alleen niet in de lijst van forms daarom moeten deze nog
            // verwijdert worden van dit programma.
            if (OuderForm != null)
            {
                var geslotenForm = sender as Form1;
                MessageBox.Show(geslotenForm.Name.ToString() + " wordt verwijderd uit lijst ChildForms van " + OuderForm.Name.ToString());
                OuderForm.ChildForms.Remove(geslotenForm);
            }
        }

        //14. een makkelijke...wat doet de onderstaande method?
        // De method cleart de textbox
        private void BtnClearLogText_Click(object sender, EventArgs e)
        {
            tbLogText.Clear();
        }
    }
}
