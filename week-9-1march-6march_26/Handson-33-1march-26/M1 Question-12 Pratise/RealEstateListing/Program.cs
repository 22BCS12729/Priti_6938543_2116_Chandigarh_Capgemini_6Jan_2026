            using System;
            using System.Collections.Generic;
            using System.Linq;

                public class RealEstateListing
                {
                    public int Id { get; set; }
                    public string Address { get; set; }
                    public string City { get; set; }
                    public decimal Price { get; set; }
                }

                public class RealEstateManager
                {
                    private List<RealEstateListing> listings = new List<RealEstateListing>();

                    public void AddListing(RealEstateListing listing)
                    {
                        listings.Add(listing);
                    }

                    public void RemoveListing(int id)
                    {
                        listings.RemoveAll(x => x.Id == id);
                    }

                    public List<RealEstateListing> SearchByCity(string city)
                    {
                        return listings.Where(x => x.City == city).ToList();
                    }

                    public decimal AveragePrice()
                    {
                        if (listings.Count == 0) return 0;
                        return listings.Average(x => x.Price);
                    }
                }

                class Solution
                {
                    static void Main()
                    {
                        RealEstateManager manager = new RealEstateManager();

                        int n = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < n; i++)
                        {
                            var input = Console.ReadLine().Split(' ');
                            manager.AddListing(new RealEstateListing
                            {
                                Id = Convert.ToInt32(input[0]),
                                Address = input[1],
                                City = input[2],
                                Price = Convert.ToDecimal(input[3])
                            });
                        }

                        Console.WriteLine("Average Price: " + manager.AveragePrice());
                    }
                }