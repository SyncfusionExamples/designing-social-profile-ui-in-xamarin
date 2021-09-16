using System;
using System.Collections.ObjectModel;
using DailyUIApp.Models;

namespace DailyUIApp.ViewModels
{
    public class ProfileViewModel
    {
        public ObservableCollection<SocialNetworks> sn { get; set; }
        public ObservableCollection<Albums> albums { get; set; }

        public ProfileViewModel()
        {
            sn = new ObservableCollection<SocialNetworks>
            {
                new SocialNetworks { Picture= "Dribble", BGColor="#ffeef3"},
                new SocialNetworks { Picture= "BE", BGColor="#eaf2ff"},
                new SocialNetworks { Picture= "Instagram", BGColor="#f7f6f8"},
                new SocialNetworks { Picture= "LinkedIn", BGColor="#e8f7ff"}

            };

            albums = new ObservableCollection<Albums>
            {
                new Albums { Picture="Profile1"},
                new Albums { Picture="Profile2"},
                new Albums { Picture="Profile3"},
                new Albums { Picture="Profile4"},
                new Albums { Picture="Profile5"},
                new Albums { Picture="Profile6"}
            };
        }
    }
}
