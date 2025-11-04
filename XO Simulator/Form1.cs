namespace XO_Simulator
{
    public partial class Form1 : Form
    {
        int day = 1; //initializes the simulator on Day 1
        int budget = 50000; //Gives the player an initial budget of 50,000 of whatever arbitrary currency they wish to use (since no DoD organization is running on just 50K dollars, we're using this as an abstraction
        string[] supplyCat = { "Rations", "Fuel", "Munitions", "Medical Supplies", "Maintenance Equipment" }; //This array won't be modified, but is still necessary so the programmer can visualize what's going on in the readiness status array
                                                                                                              //It'll also be used in conjunction so when a table needs to be displayed, the slot the category is in will match the slot that the status is in.
        float[] readinessStatus = { 0.8F, 0.8F, 0.8F, 0.8F, 0.8F }; //This array holds the percentage of readiness for each of the categories listed in the supply category array.  Another option would have been to code this as a 
                                                                    // double instead of a float, but to be honest, the sole reason I went this route was just to play with the way numbers are formatted in C#, but either one would work just the same
        int supplyCost = 1000; //this is a placeholder value as we'll be making an array to have different categories cost different amounts.

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = $"Budget: {budget:N0}";
        }
    }
}
