using System.Security.Policy;

namespace EmmerVolLatenLopen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(BucketSizeTxtBox.Text, out int bucketSizeInL);
            int.TryParse(CupSizeTxtBox.Text, out int cupSizeInCL);

            var bucketCapacityML = FluidAmountInML.FromLitres(bucketSizeInL);
            var cupSizeML = FluidAmountInML.FromCl(cupSizeInCL);

            Bucket bucket = new Bucket(bucketCapacityML, cupSizeML);

            while (!bucket.IsFull())
            {
                bucket.CurrentLevelML.VolumeMl += cupSizeML.VolumeMl;


                Thread.Sleep(100);
                Application.DoEvents();
            }

        }

        record Bucket(FluidAmountInML MaxCapacityML, FluidAmountInML CurrentLevelML)
        {
            public FluidAmountInML CurrentLevelML { get; set; } = new() { VolumeMl = 0};
            public bool IsFull()
            {
                return CurrentLevelML.VolumeMl >= MaxCapacityML.VolumeMl;
            }
        }

        record FluidAmountInML()
        {
            public int VolumeMl { get; set; }

            public static FluidAmountInML FromLitres(int litres)
            {
                return new FluidAmountInML { VolumeMl = litres * 1000 };
            }

            public static FluidAmountInML FromCl(int centilitres)
            {
                return new FluidAmountInML { VolumeMl = centilitres * 10 };
            }
        }
    }
}
