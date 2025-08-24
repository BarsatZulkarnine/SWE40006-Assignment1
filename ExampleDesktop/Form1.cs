using System;
using System.Windows.Forms;
using GreetingDependency;
using RGB.Dependency;

namespace ExampleDesktop
{
    public partial class Form1 : Form
    {
        private Button button1;
        private Label label1;
        private GreetingHelper helper;
        private BackgroundColorChanger colorChanger;


        public Form1()
        {
            InitializeComponent();
            helper = new GreetingHelper();

            label1 = new Label();
            label1.Text = helper.GetWelcomeMessage();
            label1.Location = new System.Drawing.Point(20, 20);
            label1.AutoSize = true;

            button1 = new Button();
            button1.Text = "Click Me";
            button1.Location = new System.Drawing.Point(20, 60);
            button1.Click += Button1_Click;

            this.Controls.Add(label1);
            this.Controls.Add(button1);
            this.Text = helper.GetTimestamp();

            colorChanger = new BackgroundColorChanger(this);


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Button clicked! Nice to see you.";
        }
    }
}
