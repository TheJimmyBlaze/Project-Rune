using ProjectRune.Models;
using ProjectRune.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using static ProjectRune.Services.NavigationService;

namespace ProjectRune.ViewModels
{
    public class SkillsSummaryViewModel : ViewModelBase
    {
        public bool DisplaySkillView { get => navService.ActiveNavigationSheet == NavigationSheet.Settings; }

        private List<Skill> skills;
        public List<Skill> Skills
        {
            get
            {
                if (skills != null)
                    return skills;
                return skills = GenSkills();
            }
        }

        private List<Skill> GenSkills()
        {
            return new List<Skill>()
            {
                new Skill() { NaturalID = "Attack" },
                new Skill() { NaturalID = "Strength" },
                new Skill() { NaturalID = "Defence" },
                new Skill() { NaturalID = "Hitpoints" }
            };
        }

        public SkillsSummaryViewModel()
        {
            navService.ActiveNavigationSheetChanged += delegate { OnPropertyChanged(nameof(DisplaySkillView)); };
        }
    }
}
