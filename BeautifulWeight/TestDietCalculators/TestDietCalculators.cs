﻿using BeautifulWeight.DietCalculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautifulWeight.Menu;
using BeautifulWeight.Persistence;
using BeautifulWeight.Users;
using BeautifulWeight.Model;
using BeautifulWeight.Utils;
using BeautifulWeight.Kitchen;

namespace BeautifilBeautifulWeight.DietCalculators
{
    public class PointDietCalculator : DietCalculator
    {
        private readonly KitchenManager _kitchenManager;

        private KitchenManager KitchenManager
        {
            get { return _kitchenManager; }
        }

        public PointDietCalculator()
        {

            _kitchenManager = ManagerProvider.getManager<KitchenManager>();
        }

        public string Description
        {
            get
            {
                return "Point Diet";
            }
        }

        public Serving GetEquivalent(Serving serving, UserProfile userProfile)
        {
            Serving s = new Serving(KitchenManager.Dishes.RandomElement(), new Random().Next(120));
            return s;
        }

        public bool IsCompatibleWith(Goal goal)
        {
            return true;
        }

        public WeeklyMenu NewMenu(UserProfile userProfile)
        {
            WeeklyMenu result = new WeeklyMenu(this);
            Random rnd = new Random();
            foreach (DailyMenu dm in result)
            {
                int num = rnd.Next(1, 4);
                for (int i = 0; i < num; i++)
                {
                    List<Serving> servings = new List<Serving>();
                    int num2 = rnd.Next(1, 3);
                    for (int j = 0; j < num2; j++)
                    {
                        servings.Add(new Serving(KitchenManager.Dishes.RandomElement(), new Random().Next(120)));
                    }
                    NonEmptyList<Serving> nonempty = new NonEmptyList<Serving>(servings[0]);
                    for (int j = 1; j < servings.Count; j++)
                    {
                        nonempty.Add(servings[j]);
                    }
                    dm.Meals.Add(new Meal("pasto " + i, new DateTime(2000, 1, 1, rnd.Next(24), rnd.Next(60), 0), nonempty));
                }
            }
            return result;
        }
    }

    public class KcalDietCalculator : DietCalculator
    {
        private readonly KitchenManager _kitchenManager;

        private KitchenManager KitchenManager
        {
            get { return _kitchenManager; }
        }

        public KcalDietCalculator()
        {

            _kitchenManager = ManagerProvider.getManager<KitchenManager>();
        }

        public string Description
        {
            get
            {
                return "Kcal Diet";
            }
        }

        public Serving GetEquivalent(Serving serving, UserProfile userProfile)
        {
            Serving s = new Serving(KitchenManager.Dishes.RandomElement(), new Random().Next(120));
            return s;
        }

        public bool IsCompatibleWith(Goal goal)
        {
            switch (goal)
            {
                case Goal.MAINTAINANCE: return false;
                default: return true;
            }
        }

        public WeeklyMenu NewMenu(UserProfile userProfile)
        {
            WeeklyMenu result = new WeeklyMenu(this);
            Random rnd = new Random();
            foreach (DailyMenu dm in result)
            {
                int num = rnd.Next(1, 4);
                for (int i = 0; i < num; i++)
                {
                    List<Serving> servings = new List<Serving>();
                    int num2 = rnd.Next(1, 3);
                    for (int j = 0; j < num2; j++)
                    {
                        servings.Add(new Serving(KitchenManager.Dishes.RandomElement(), new Random().Next(120)));
                    }
                    NonEmptyList<Serving> nonempty = new NonEmptyList<Serving>(servings[0]);
                    for (int j = 1; j < servings.Count; j++)
                    {
                        nonempty.Add(servings[j]);
                    }
                    dm.Meals.Add(new Meal("pasto " + i, new DateTime(2000, 1, 1, rnd.Next(24), rnd.Next(60), 0), nonempty));
                }
            }
            return result;
        }
    }
}
