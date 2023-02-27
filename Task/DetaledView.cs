using BusinessLogicLayer.EntityList;
using BusinessLogicLayer.EntityManager;
using BusinessLogicLayerEntityBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class DetaledView : Form
    {
        TitleList TitleList;
        CurrencyManager currencyManager1;
        PublisherList pubs;
        BindingNavigator bindingNavigator;
        BindingSource PrdBindingSource;
        public DetaledView()
        {
            InitializeComponent();
        }

        private void DetaledView_Load(object sender, EventArgs e)
        {
            TitleList = TitleManager.SelectAllTitles();
            pubs = PublisherManager.SelectAllPublishers();

            pubCombo.DataSource = pubs;
            pubCombo.DisplayMember = "pub_name";
            pubCombo.ValueMember = "pub_id";

            PrdBindingSource = new BindingSource(TitleList, "");
            ///Simple Data Binding
            txt_titleId.DataBindings.Add("Text", PrdBindingSource, "title_id",true);
            txt_titleName.DataBindings.Add("Text", PrdBindingSource, "title", true);
            txt_titleType.DataBindings.Add("Text", PrdBindingSource, "type", true);
            txt_titlePrice.DataBindings.Add("Text", PrdBindingSource, "price", true);
            pubCombo.DataBindings.Add(
                    new System.Windows.Forms.Binding("SelectedValue", PrdBindingSource, "pub_id", true));
           

            bindingNavigator = new BindingNavigator(PrdBindingSource);
            this.Controls.Add(bindingNavigator);

            bindingNavigator.DeleteItem.Click += func;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TitleList.Count; i++)
            {
                if (TitleList[i].State == EntityState.Changed)
                {
                    TitleManager.UpdateTitleByTitleID(TitleList[i].title_id, TitleList[i]);
                }
                else if (TitleList[i].State == EntityState.Deleted)
                {
                    TitleManager.DeleteTitleByTitleID(TitleList[i].title_id);
                    TitleList.Remove(TitleList[i]);
                    currencyManager1.Refresh();


                }
                else if (TitleList[i].State == EntityState.Added)
                {
                    TitleManager.AddNewTitle(TitleList[i]);
                }

            }
        }
        public void func(object sender, EventArgs e)
        {

            






        }

        private void button2_Click(object sender, EventArgs e)
        {
            TitleManager.DeleteTitleByTitleID(txt_titleId.Text);
            bindingNavigator.DeleteItem.PerformClick();
        }

    }
}
