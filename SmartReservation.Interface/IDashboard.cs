﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartReservation.Interface
{
    public interface IDashboard
    {
        Task<Model.ReservationBooked> GetBookedReservations();
        Task<Model.ReservationArrived> GetArrivedReservations();
        Task<Model.ReservationComplete> GetCompleteReservations();
    }
}