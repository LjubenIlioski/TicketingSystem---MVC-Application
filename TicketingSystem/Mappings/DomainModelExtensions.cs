﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;
using TicketingSystem.ViewModels;

namespace TicketingSystem.Mappings
{
    public static class DomainModelExtensions
    {
        public static TicketOverviewModel ToOverviewModel(this Ticket ticket)
        {
            return new TicketOverviewModel()
            {
                Id = ticket.Id,
                Description = ticket.Description,
                DateCreated = ticket.DateCreated,
                TicketStatus = ticket.TicketStatus,
                Title = ticket.Title,
                UserId = ticket.UserId

            };
        }

        public static TicketDetailsModel ToDetailsModel(this Ticket ticket)
        {
            return new TicketDetailsModel()
            {
                Id = ticket.Id,
                Description = ticket.Description,
                DateCreated = ticket.DateCreated,
                TicketStatus = ticket.TicketStatus,
                Title = ticket.Title,
                Comments = ticket.Comments.Select(x => x.ToCommentModel()).ToList()
            };
        }

        public static TicketCommentModel ToCommentModel(this Comment comment)
        {
            return new TicketCommentModel
            {
                Id = comment.Id,
                Message = comment.Message,
                DateCreated = comment.DateCreated,
                Username = comment.User.Username,
                IsAdmin = comment.User.IsAdmin,
              
            };
        }

    }
}
