﻿using ProjectRune.Models;
using ProjectRune.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRune.ViewModels
{
    public class SkillsSummaryViewModel : ViewModelBase
    {
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
                new Skill()
                {
                    NaturalID = "Attack",
                    ColourHex = "4A0C06"
                },
                new Skill()
                {
                    NaturalID = "Strength",
                    ColourHex = "015534"
                },
                new Skill()
                {
                    NaturalID = "Defence",
                    ColourHex = "657CC9"
                },
                new Skill()
                {
                    NaturalID = "Attack",
                    ColourHex = "4A0C06"
                },
                new Skill()
                {
                    NaturalID = "Strength",
                    ColourHex = "015534"
                },
                new Skill()
                {
                    NaturalID = "Defence",
                    ColourHex = "657CC9"
                },
                new Skill()
                {
                    NaturalID = "Attack",
                    ColourHex = "4A0C06"
                },
                new Skill()
                {
                    NaturalID = "Strength",
                    ColourHex = "015534"
                },
                new Skill()
                {
                    NaturalID = "Defence",
                    ColourHex = "657CC9"
                },
                new Skill()
                {
                    NaturalID = "Attack",
                    ColourHex = "4A0C06"
                },
                new Skill()
                {
                    NaturalID = "Strength",
                    ColourHex = "015534"
                },
                new Skill()
                {
                    NaturalID = "Defence",
                    ColourHex = "657CC9"
                },
                new Skill()
                {
                    NaturalID = "Attack",
                    ColourHex = "4A0C06"
                },
                new Skill()
                {
                    NaturalID = "Strength",
                    ColourHex = "015534"
                },
                new Skill()
                {
                    NaturalID = "Defence",
                    ColourHex = "657CC9"
                },
                new Skill()
                {
                    NaturalID = "Attack",
                    ColourHex = "4A0C06"
                },
                new Skill()
                {
                    NaturalID = "Strength",
                    ColourHex = "015534"
                },
                new Skill()
                {
                    NaturalID = "Defence",
                    ColourHex = "657CC9"
                },
                new Skill()
                {
                    NaturalID = "Attack",
                    ColourHex = "4A0C06"
                },
                new Skill()
                {
                    NaturalID = "Strength",
                    ColourHex = "015534"
                },
                new Skill()
                {
                    NaturalID = "Defence",
                    ColourHex = "657CC9"
                },
                new Skill()
                {
                    NaturalID = "Attack",
                    ColourHex = "4A0C06"
                },
                new Skill()
                {
                    NaturalID = "Strength",
                    ColourHex = "015534"
                },
                new Skill()
                {
                    NaturalID = "Defence",
                    ColourHex = "657CC9"
                },
                new Skill()
                {
                    NaturalID = "Attack",
                    ColourHex = "4A0C06"
                },
                new Skill()
                {
                    NaturalID = "Strength",
                    ColourHex = "015534"
                },
                new Skill()
                {
                    NaturalID = "Defence",
                    ColourHex = "657CC9"
                },
                new Skill()
                {
                    NaturalID = "Attack",
                    ColourHex = "4A0C06"
                },
                new Skill()
                {
                    NaturalID = "Strength",
                    ColourHex = "015534"
                },
                new Skill()
                {
                    NaturalID = "Defence",
                    ColourHex = "657CC9"
                },
            };
        }
    }
}
