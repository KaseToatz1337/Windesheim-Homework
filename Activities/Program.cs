using System.Text;

namespace Activities
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Creating a new invitation. Please enter your details.");
            string organisorName = Invitation.getValue("Your name: ");
            string organisorEmail = Invitation.getValue("Your email: ");
            Person organisor = new(organisorName, organisorEmail);
            Console.Clear();
            Console.WriteLine("Enter activity details.");
            string activityTitle = Invitation.getValue("Activity title: ");
            DateOnly activityDate = Invitation.getDate("Activity date (DD/MM/YYYY): ");
            string activityDescription = Invitation.getValue("Activity description: ");
            Activity activity = new(activityTitle, activityDate, activityDescription);
            Console.Clear();
            List<Person> invitees = [];
            bool addInvitee = true;
            while (addInvitee)
            {
                Console.WriteLine("Enter invitee details.");
                string inviteeName = Invitation.getValue("Invitee name: ");
                string inviteeEmail = Invitation.getValue("Invitee email: ");
                Person invitee = new(inviteeName, inviteeEmail);
                invitees.Add(invitee);
                addInvitee = Invitation.getResponse("Do you wish to add another invitee? (Y/N): ");
            }
            Console.Clear();
            foreach (Person invitee in invitees)
            {
                Console.WriteLine($"Dear {invitee.getName()}, you have been invited for \"{activity.getTitle()}\" on {activity.getDate()}. Description: {activity.getDescription()}\n\nKind regards,\n{organisor.getName()}");
            }
        }
    }
}
