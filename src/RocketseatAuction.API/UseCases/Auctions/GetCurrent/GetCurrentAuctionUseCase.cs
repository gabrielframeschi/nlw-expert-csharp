﻿using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var repository = new RocketseatAuctionDbContext();
        // var today = DateTime.UtcNow;
        var today = new DateTime(2024, 01, 25);

        return repository
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => auction.Starts <= today && auction.Ends >= today);
    }
}
