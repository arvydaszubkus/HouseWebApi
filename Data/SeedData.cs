using Microsoft.EntityFrameworkCore;

public static class SeedData
{
    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<HouseEntity>().HasData(new List<HouseEntity> {
            new HouseEntity {
                Id = 1,
                Address = "12 Valley of Kings, Lucern",
                Country = "Switzerland",
                Description = "The apartment is composed of large entrance hall, service bathroom with laundry area, large living room with balcony, kitchen separated by a wall and glass door, possibility of furnishing the kitchen, sleeping area with two bedrooms, balcony and large bathroom with tub.",
                Price = 700000
            },
            new HouseEntity
            {
                Id = 2,
                Address = "89 Road of Forks, Zurich",
                Country = "Switzerland",
                Description = "Living Dimore Milanesi means living in wonderful apartments. The combination of materials of the past and contemporary workmanship has given life to living spaces of considerable charm and suggestion, which drag like a whirlwind of pleasant sensations to each return home.",
                Price = 600000
            },
            new HouseEntity
            {
                Id = 3,
                Address = "Grote Hof 12, Brugge",
                Country = "The Belgium",
                Description = "In the Fiera area, on the second floor of a recent residential building with nine floors above ground, a real estate unit for a total of 112 commercial square meters in an excellent state of maintenance comprising entrance hall, living area with 22 square meter terrace, open kitchen, two bedrooms bedroom, two bathrooms, cellar and garage in the building.",
                Price = 300500
            },
            new HouseEntity
            {
                Id = 4,
                Address = "Meel Kade 321, The Amsterdam",
                Country = "The Netherlands",
                Description = "An exclusive property courtyard area is annexed to the mezzanine floor. The heating system is centralized while the cooling system is autonomous with a split in each room. The property is completed by some rooms for office use located in the basement, accessible only through the common entrance hall. ",
                Price = 759500
            },
            new HouseEntity
            {
                Id = 5,
                Address = "Oude Gracht 32, Brussels",
                Country = "The Belgium",
                Description = "A wonderful frescoed entrance connects the double living room with the dining room and the study. The living area overlooks the enchanting terrace, ideal for relaxing readings and to enjoy a splendid sunny day. The large large eat-in kitchen is separate and equipped with a functional pantry. The service area is equipped with a dedicated lift, bedroom, laundry room and bathroom.",
                Price = 500500
            },
            new HouseEntity
            {
                Id = 6,
                Address = "Oude Gracht Gent 32, Brussels",
                Country = "The Belgium",
                Description = "The living area overlooks the enchanting terrace, ideal for relaxing readings and to enjoy a splendid sunny day. The large large eat-in kitchen is separate and equipped with a functional pantry. The service area is equipped with a dedicated lift, bedroom, laundry room and bathroom.",
                Price = 500500
            },
            new HouseEntity
            {
                Id = 7,
                Address = "Oude Gracht Tent 32, Brussels",
                Country = "The Belgium",
                Description = "A wonderful frescoed entrance connects the double living room with the dining room and the study. The living area overlooks the enchanting terrace, ideal for relaxing readings and to enjoy a splendid sunny day. The large large eat-in kitchen is separate and equipped with a functional pantry. The service area is equipped with a dedicated lift, bedroom, laundry room and bathroom.",
                Price = 500500
            }
        });
        builder.Entity<BidEntity>().HasData(new List<BidEntity>
        {
            new BidEntity { Id = 1, HouseId = 1, Bidder = "Kennedy Murray", Amount = 300000 },
            new BidEntity { Id = 2, HouseId = 1, Bidder = "Boston Cruz", Amount = 202900 },
            new BidEntity { Id = 3, HouseId = 2, Bidder = "Mira Kirk", Amount = 302400 },
            new BidEntity { Id = 4, HouseId = 2, Bidder = "Kennedi Wang", Amount = 370500 },
            new BidEntity { Id = 5, HouseId = 2, Bidder = "Dayami Schmitt", Amount = 412400 },
            new BidEntity { Id = 6, HouseId = 3, Bidder = "Quinten Kidd", Amount = 212000 },
            new BidEntity { Id = 7, HouseId = 4, Bidder = "Natalia Cisneros", Amount = 417000 },
            new BidEntity { Id = 8, HouseId = 4, Bidder = "Ross Gaines", Amount = 470000 },
            new BidEntity { Id = 9, HouseId = 4, Bidder = "Aaron Wyatt", Amount = 450000 },
            new BidEntity { Id = 10, HouseId = 5, Bidder = "Roman Calhoun", Amount = 490000 },
            new BidEntity { Id = 11, HouseId = 5, Bidder = "Ross Gaines", Amount = 170000 },
            new BidEntity { Id = 12, HouseId = 5, Bidder = "Aaron Wyatt", Amount = 190000 },
            new BidEntity { Id = 13, HouseId = 5, Bidder = "Aennedy Murray", Amount = 190000 },
            new BidEntity { Id = 14, HouseId = 5, Bidder = "Boston Cruz", Amount = 190000 },
        });
    }
}