using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PricingCondition
{
    public partial class Form1 : Form
    {
        static BindingList<Condition> ConditionList = new BindingList<Condition>();

        static BindingList<PricingCondition> PricingConditionList = new BindingList<PricingCondition>();

        static BindingList<PricingEvent> PricingEventList = new BindingList<PricingEvent>();

        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            PopulatePricingConditionData();
            PopulateConditionData();

            PopulatePricingEvent();

        }
        private void PopulatePricingEvent() {

            PricingEventList.Add(new PricingEvent()
            {
                 Id=1,
                  TypeDescription ="Single Ad"
            });

            PricingEventList.Add(new PricingEvent()
            {
                Id = 2,
                TypeDescription = "Subscription"
            });

            PricingEventList.Add(new PricingEvent()
            {
                Id = 3,
                TypeDescription = "Promotion"
            });

            PricingEventList.Add(new PricingEvent()
            {
                Id = 4,
                TypeDescription = "TopOfList"
            });
            PricingEventList.Add(new PricingEvent()
            {
                Id = 5,
                TypeDescription = "Click"
            });


            dataGridView3.DataSource = PricingEventList;

        }
        private void PopulateConditionData() {

            
                ConditionList.Add(new Condition()
                {

                    id = 1,
                    Sequence = 1,
                    PricingConditionId = "CatS",
                    PricingEventId = 1,
                    UserId = 0,
                    SubsctiptionTypeId = null,
                    PromotionId = 0,
                    ValidityStart = DateTime.MinValue,
                    ValidityEnd = DateTime.MaxValue,
                    Amount = 20,
                    Currency = "USD",
                    Comments = "Single Add purchase"

                });
                ConditionList.Add(new Condition()
                {

                    id = 2,
                    Sequence = 2,
                    PricingConditionId = "Cat100",
                    PricingEventId = 2,
                    UserId = 0,
                    SubsctiptionTypeId = 1,
                    PromotionId = 0,
                    ValidityStart = DateTime.MinValue.AddDays(666),
                    ValidityEnd = DateTime.MaxValue,
                    Amount = 100,
                    Currency = "USD",
                    Comments = "100 Ad purchase"

                });
                ConditionList.Add(new Condition()
                {

                    id = 3,
                    Sequence = 3,
                    PricingConditionId = "Cat300",
                    PricingEventId = 2,
                    UserId = 0,
                    SubsctiptionTypeId = 2,
                    PromotionId = 0,
                    ValidityStart = DateTime.MinValue.AddDays(666),
                    ValidityEnd = DateTime.MaxValue,
                    Amount = 200,
                    Currency = "USD",
                    Comments = "200 Ad purchase"

                });

            
            dataGridView1.DataSource = ConditionList;
            dataGridView2.DataSource = PricingConditionList;
            
        }

        private void PopulatePricingConditionData() {

            PricingConditionList.Add(new PricingCondition()
            {
                Id = 1,
                Condition = "CatS",
                Sequence = "100",
                ConditionDescription = "Catalogue Price Single Ad"

            });
            PricingConditionList.Add(new PricingCondition()
            {
                Id = 2,
                Condition = "Cat100",
                Sequence = "101",
                ConditionDescription = "Catalogue Price Subscription 100"

            });
            PricingConditionList.Add(new PricingCondition()
            {
                Id = 1,
                Condition = "Cat200",
                Sequence = "102",
                ConditionDescription = "Catalogue Price Subscription 200"

            });
            PricingConditionList.Add(new PricingCondition()
            {
                Id = 1,
                Condition = "Cat300",
                Sequence = "103",
                ConditionDescription = "Catalogue Price Subscription 300"

            });

            PricingConditionList.Add(new PricingCondition()
            {
                Id = 1,
                Condition = "DisS",
                Sequence = "200",
                ConditionDescription = "Discount Price Single Ad"

            });

            PricingConditionList.Add(new PricingCondition()
            {
                Id = 1,
                Condition = "Dis100",
                Sequence = "201",
                ConditionDescription = "Discount Price Subsscription 100"

            });

            PricingConditionList.Add(new PricingCondition()
            {
                Id = 1,
                Condition = "Dis200",
                Sequence = "202",
                ConditionDescription = "Discount Price Subsscription 200"

            });

            PricingConditionList.Add(new PricingCondition()
            {
                Id = 1,
                Condition = "Dis300",
                Sequence = "203",
                ConditionDescription = "Discount Price Subsscription 300"

            });

            PricingConditionList.Add(new PricingCondition()
            {
                Id = 1,
                Condition = "ProTop",
                Sequence = "300",
                ConditionDescription = "Promotion Top List Single Ad"

            });


            dataGridView2.DataSource = PricingConditionList;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CalculatePrice(12345).ToString());
        }

        private int CalculatePrice(int CustomerId)
        {

            return 200;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

    }
}
