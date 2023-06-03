using FinalProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FInalProject.E_Certs.E_Cert;

namespace FInalProject.E_Certs
{
    public class E_Cert
    {
        private List<String>
            send_as_email_address_list,
            customer_email_address_list,
            cc_email_address_list;

        private Window documents_window_instace;
        private bool generated_ecert_status_icon;

        public enum Email_Address_List
        {
            SEND_AS = 0,
            CUSTOMER = 1,
            CC = 2
        }

        public E_Cert()
        {
            send_as_email_address_list = Example_Email_List_Factory.GenerateEmailList("send_as_user{0}@example.com", 1, 2);
            customer_email_address_list = Example_Email_List_Factory.GenerateEmailList("customer_user{0}@example.com", 1, 6);
            cc_email_address_list = Example_Email_List_Factory.GenerateEmailList("cc_as_user{0}@example.com", 1, 4);

            generated_ecert_status_icon = false;
        }

        public void remove_Selected_Emails_From_List(List<String> emails_to_remove_from_list, Email_Address_List email_list_to_remove_from)
        {
            foreach (String email in emails_to_remove_from_list)
            {
                remove_Selected_Emails_From_List(email, email_list_to_remove_from);
            }
        }

        public void remove_Selected_Emails_From_List(String email_to_remove_from_list, Email_Address_List email_list_to_remove_from)
        {
            get_email_address_list(email_list_to_remove_from).Remove(email_to_remove_from_list);
        }

        public List<String> get_email_address_list(Email_Address_List email_list_to_remove_from)
        {
            switch (email_list_to_remove_from)
            {
                case Email_Address_List.SEND_AS:
                    return send_as_email_address_list;
                case Email_Address_List.CUSTOMER:
                    return customer_email_address_list;
                case Email_Address_List.CC:
                    return cc_email_address_list;
                default:
                    throw new Exception("List unrecognized, please use an email_address_list");
            }
        }

        public void generate_ecert_document(Window instance_of_order_window, bool ecert_status)
        {
            //Would contain PDF Generation here

            documents_window_instace = instance_of_order_window;
            generated_ecert_status_icon = ecert_status;

            generated_ecert_status_icon = true;
        }
    }

    internal class Example_Email_List_Factory
    {
        public static List<string> GenerateEmailList(string format, int startRange, int endRange)
        {
            List<string> emailList = new List<string>();

            for (int i = startRange; i <= endRange; i++)
            {
                string email = string.Format(format, i);
                emailList.Add(email);
            }

            return emailList;
        }
    }
}
