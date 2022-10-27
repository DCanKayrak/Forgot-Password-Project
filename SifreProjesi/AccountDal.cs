using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SifreProjesi
{
    public class AccountDal
    {
        public bool LogIn(Account account)
        {
            using(SifreProjesiContext context = new SifreProjesiContext())
            {
                var deger = context.Accounts.SingleOrDefault(p => p.Mail.Equals(account.Mail) && p.Password.Equals(account.Password));
                if(deger != null)
                {
                    return true;
                }
                else { return false; }
            }
        }
        public bool isAccountExists(string mail)
        {
            using(SifreProjesiContext context = new SifreProjesiContext())
            {
                var result = context.Accounts.SingleOrDefault(p => p.Mail.Equals(mail));
                if(result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void Update(Account account)
        {
            using(SifreProjesiContext context = new SifreProjesiContext())
            {
                var entity = context.Entry(account);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
            
        }
        public Account GetAccount(string mail)
        {
            using(SifreProjesiContext context = new SifreProjesiContext())
            {
                if (isAccountExists(mail))
                {
                    var acc = context.Accounts.SingleOrDefault(p => p.Mail.Equals(mail));
                    return acc;
                }
                else
                {
                    return null;
                }
                
            }
        }
    }
}
