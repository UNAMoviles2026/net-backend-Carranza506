using reservations_api.DTOs.Requests;
using reservations_api.DTOs.Responses;
using reservations_api.Models.Entities;

namespace reservations_api.Services;

public interface IReservationService
{
  Task<ReservationResponse> CreateAsync(CreateReservationRequest request);
  Task<bool> DeleteReservationAsync(Guid reservationId);
}
