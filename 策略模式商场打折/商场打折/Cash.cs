using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 商场打折
{
    abstract class Cashsuper
    {
        //现金收取抽象方法
        public abstract double acceptCash(double money);
    }

    //正常收费类
    class CashNormal : Cashsuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }

    //打折收费子类
    class CashRebate : Cashsuper
    {
        private double moneyRebate = 1d;

        public CashRebate(string moneyDiscount)
        {
            this.moneyRebate = double.Parse(moneyDiscount);
        }
        public override double acceptCash(double money)
        {
            double result = money * moneyRebate;
            return result;
        }
    }

    //返利收费子类
    class CashReturn : Cashsuper
    {
        private double moneyCondition = 0d;
        private double moneyReturn = 0d;

        public CashReturn(string MoneyCondition, string Moneyreturn)
        {
            this.moneyCondition = double.Parse(MoneyCondition);
            this.moneyReturn = double.Parse(Moneyreturn);
        }
        public override double acceptCash(double money)
        {
            double result = money;
            if (money >= moneyCondition)
            {
                result = money - (int)(money / moneyCondition) * moneyReturn;
            }
            return result;
        }   
    }

    //现金收费工厂类
    class CashFactory
    {
        public static Cashsuper createCashAccept(string type)
        {
            Cashsuper cs = null;
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "单价满300返100":
                    cs = new CashReturn("300","100");
                    break;
                case "打8折":
                    cs = new CashRebate("0.8");
                    break;
            }
            return cs;
        }
    }

    //策略模式类,将实例化具体策略的过程由客户端转移到这里
    class CashContext
    {
        Cashsuper cs = null;
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    CashNormal cs0 = new CashNormal();
                    cs = cs0;
                    break;
                case "单价满300返100":
                    CashReturn cr = new CashReturn("300", "100");
                    cs = cr;
                    break;
                case "打8折":
                    CashRebate cr2 = new CashRebate("0.8");
                    cs = cr2;
                    break;
            }
        }

        public double getResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}
