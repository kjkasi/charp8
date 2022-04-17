using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class BankAccount
    {
        public string Owner { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(string Owner)
        {
            this.Owner = Owner;
            this.Balance = 0M;
        }

        public void Deposit(decimal Summa)
        {
            if (Summa < 0) throw new ArgumentException("Summa < 0");
            Balance += Summa;
        }

        public bool WithDraw(decimal Summa)
        {
            if (Summa < 0) throw new ArgumentException("Summa < 0");
            if (Balance > Summa)
            {
                Balance -= Summa;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{Owner} : {Balance}";
        }

        public static bool Transfer(BankAccount source, BankAccount dest, decimal Summa)
        {
            if (source.WithDraw(Summa))
            {
                dest.Deposit(Summa);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
