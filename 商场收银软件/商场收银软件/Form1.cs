using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 商场收银软件
{
    public partial class Form1 : Form
    {
        double total = 0.0d;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxType.Items.AddRange(new Object[]{"正常收费", "满300返100", "打8折"});
            cbxType.SelectedIndex = 0;
        }



        private void bntOk_Click(object sender, EventArgs e)
        {
            //CashSuper csuper = CashFactory.createCashAccept(cbxType.SelectedItem.ToString());
            CashContext csuper = new CashContext(cbxType.SelectedItem.ToString());
            double totalPrice = 0d;
            totalPrice = csuper.GetResult (Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
            total = total + totalPrice;
            lbxList.Items.Add("单价："+txtPrice.Text + " 数量："+txtNum.Text + " " + cbxType.SelectedItem + " 合计："+totalPrice.ToString());
            lblResult.Text = total.ToString();
        }
        private void bntCancel_Click(object sender, EventArgs e)
        {
            lbxList.Items.Clear();
            lblResult.Text = "0.0";
        }
        private void lbxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxList_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void labelPrice_Click(object sender, EventArgs e)
        {

        }
        private void labelNum_Click(object sender, EventArgs e)
        {

        }
    }
    //上下文类，主要用特定的算法来返回价格
    class CashContext
    {
        CashSuper cs = null;
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    CashNormal cs0 = new CashNormal();
                    cs = cs0;
                    break;
                case "满300返100":
                    CashReturn cs1 = new CashReturn("300", "100");
                    cs = cs1;
                    break;
                case "打8折" :
                    CashRebate cs2 = new CashRebate("0.8");
                    cs = cs2;
                    break;
            }
        }
        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
    //策略类，主要封装各种算法
    abstract class CashSuper{
        public abstract double acceptCash(double money);
    }

    //正常收费子类
    class CashNormal : CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }
    //打折收费子类
    class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;
        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }
        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
    //返利收费子类
    class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }
        public override double acceptCash(double money)
        {
            double result = money;
            if (money >= moneyCondition)
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            return result;
        }
    }
    //现金收费工厂
    class CashFactory
    {
        public static CashSuper createCashAccept(string type)
        {
            CashSuper cs = null;
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "满300返100":
                    CashReturn cr1 = new CashReturn("300", "100");
                    cs = cr1;
                    break;
                case "打8折":
                    CashRebate cr2 = new CashRebate("0.8");
                    cs = cr2;
                    break;
            }
            return cs;
        }
    }
}
