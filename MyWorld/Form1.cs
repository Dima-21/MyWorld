using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWorld
{
    public partial class Form1 : Form
    {
        World world = new World();
        const int TICK_DIV = 10;
        const int PriceWarrior = 50;
        const int PriceHuman = 30;
        const int LandsMaximum = 1000;
        ErrorProvider Error = new ErrorProvider();
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            ProgressBar.Maximum = LandsMaximum;
            Update();
        }
        private void Update()
        {
            TrackSell.Maximum = TrackHire.Maximum = world.Human;
            TrackSend.Maximum = world.Warriors;
            TrackSell.TickFrequency = TrackHire.TickFrequency = world.Human / TICK_DIV;
            TrackSend.TickFrequency = world.Warriors / TICK_DIV;
            LSell.Text = TrackSell.Value.ToString();
            LHire.Text = TrackHire.Value.ToString();
            LSend.Text = TrackSend.Value.ToString();
            TextHuman.Text = Convert.ToString(world.Human);
            TextWarriors.Text = Convert.ToString(world.Warriors);
            TextMoney.Text = Convert.ToString(world.Money);
            if (world.Lands > LandsMaximum)
                ProgressBar.Value = LandsMaximum;
            else if (world.Lands < 0)
                ProgressBar.Value = 0;
            else
                ProgressBar.Value = world.Lands;
        }
        private void TrackSell_Scroll(object sender, EventArgs e)
        {
            LSell.Text = TrackSell.Value.ToString();
        }

        private void TrackHire_Scroll(object sender, EventArgs e)
        {
            LHire.Text = TrackHire.Value.ToString();
        }

        private void TrackSend_Scroll(object sender, EventArgs e)
        {
            LSend.Text = TrackSend.Value.ToString();
        }

        private void BSell_Click(object sender, EventArgs e)
        {
            world.Human -= TrackSell.Value;
            world.Money += TrackSell.Value * PriceHuman;
            TrackSell.Value = 0;
            TrackHire.Value = TrackHire.Value >= world.Human ? world.Human : TrackHire.Value;
            Update();
        }

        private void BHire_Click(object sender, EventArgs e)
        {
            if (TrackHire.Value*PriceWarrior > world.Money)
            {
                Error.SetError(BHire, $"Не хватает денег. Максимум:{world.Money/PriceWarrior}");
                return;
            }
            Error.SetError(BHire, "");
            world.Human -= TrackHire.Value;
            world.Warriors += TrackHire.Value;
            world.Money -= TrackHire.Value * PriceWarrior;
            TrackHire.Value = 0;
            TrackSell.Value = TrackSell.Value >= world.Human ? world.Human : TrackSell.Value;
            Update();
        }

        private void BSend_Click(object sender, EventArgs e)
        {
            if (TrackSend.Value < 10)
            {
                Error.SetError(BSend, "Минимальное количество воинов 10");
                return;
            }
            Error.SetError(BSend, "");
            if (rand.Next(10) > 4) // Победа
            {
                world.Human += rand.Next(world.Human / 3, world.Human);
                world.Warriors -= rand.Next(TrackSend.Value / 10, TrackSend.Value / 2);
                world.Money += rand.Next(500, 10000);
                world.Lands += rand.Next(world.Warriors * 10);
            }
            else // Поражение
            {
                world.Human -= rand.Next(world.Human / 5, world.Human / 2);
                world.Warriors -= rand.Next(TrackSend.Value / 10, TrackSend.Value);
                world.Money -= rand.Next(10, world.Money);
                world.Lands -= rand.Next(world.Lands / rand.Next(TrackSend.Value));
            }
            TrackSend.Value = 0;
            if (world.Lands < 5 || world.Lands > 999 || world.Human < 10 && world.Warriors < 10)
                Finish();
            Update();
        }
        private void Finish()
        {
            if (world.Lands < 5 || world.Human < 10)
                LStats.Text = "Вы проиграли :(";
            else
                LStats.Text = "Вы выиграли :)";
            BStart.Visible = true;
        }

        private void BStart_Click(object sender, EventArgs e)
        {
            world = new World();
            LStats.Text = "";
            BStart.Visible = false;
            Update();
        }
    }
}
