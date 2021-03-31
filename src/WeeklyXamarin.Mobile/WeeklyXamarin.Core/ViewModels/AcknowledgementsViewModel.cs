﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeeklyXamarin.Core.Services;

namespace WeeklyXamarin.Core.ViewModels
{
    public class AcknowledgementsViewModel : ViewModelBase
    {
        public List<Acknowledgement> Acknowledgements { get; set; }

        public AcknowledgementsViewModel(INavigationService navigation, IAnalytics analytics) : base(navigation, analytics)
        {
            var thanks = new Acknowledgements();
            Acknowledgements = thanks.Thanks.ToList();
        }
    }
}
