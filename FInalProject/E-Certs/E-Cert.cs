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
        private PictureBox documents_status_icon;
        private Button documents_ecert_view, documents_ecert_create;

        public Ecert_Status ecert_status;

        public enum Email_Address_List
        {
            SEND_AS = 0,
            CUSTOMER = 1,
            CC = 2
        }

        public enum Ecert_Status
        {
            INSTANTIATING = -3,
            BINDING_COMPONENTS = -2,
            BINDING_EMAIL_LISTS = -1,
            ECERT_DATA_LOADED = 0,
            CREATING = 1,
            ECERT_READY = 2,
            EDITING_UNSAVED = 3,
            EDITING_SAVED = 4,
            ECERT_CLOSED = 5,
            ECERT_SENT = 6
        }

        public E_Cert(Window instance_of_order_window, PictureBox ecert_status_icon, Button ecert_view_button, Button ecert_create_button)
        {
            update_ecert_status(Ecert_Status.INSTANTIATING);
            update_ecert_status(Ecert_Status.BINDING_COMPONENTS);

            documents_window_instace = instance_of_order_window;
            documents_status_icon = ecert_status_icon;
            documents_ecert_view = ecert_view_button;
            documents_ecert_create = ecert_create_button;

            update_ecert_status(Ecert_Status.BINDING_EMAIL_LISTS); 

            send_as_email_address_list = Example_Email_List_Factory.GenerateEmailList("send_as_user{0}@example.com", 1, 2);
            customer_email_address_list = Example_Email_List_Factory.GenerateEmailList("customer_user{0}@example.com", 1, 6);
            cc_email_address_list = Example_Email_List_Factory.GenerateEmailList("cc_as_user{0}@example.com", 1, 4);

            update_ecert_status(Ecert_Status.ECERT_DATA_LOADED);
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

        public void generate_ecert_document()
        {
            //Would contain PDF Generation here

            //const string Filename = "\\Resources\\Check Icon.bmp";
            //Window.orderWindowInstance.ecert_stats.Image = Image.FromFile(Filename);

            //documents_status_icon.Image = 
            //Bind document path to view command
            
        }

        private void update_ecert_status(Ecert_Status status)
        {
            ecert_status = status;
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
