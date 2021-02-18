using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Code.Assignment.Models.StarWars;

namespace Code.Assignment.EfCore
{
    public class DbInitializer
    {
        public static void Initialize(AssignmentDBContext context)
        {
            var data = new List<Jedi>();
            var rand = new Random();
            var anakin = new Jedi
            {
                Id = "1",
                BirthDate = new DateTime(1990, 1, 1),
                Height = 1.88,
                Weight = 84,
                MidiChlorianCount = 9001,
                Title = "Dark Lord",
                Name = "Anakin",
                Surname = "Skywalker",
                LightSaber = new LightSaber
                {
                    Attack = 500,
                    Defense = 500,
                    Length = 28,
                    Width = 5,
                    Color = "Red",
                    Type = LightSaberType.Standard,
                    JediId = "1"
                },
            };

            data.Add(anakin);

            for (int i = 1; i < 21; i++)
            {
                var id = Guid.NewGuid().ToString();

                data.Add(new Jedi
                {
                    Id = id,
                    BirthDate = new DateTime(1990, 1, 1),
                    Height = Math.Round(rand.NextDouble() * (100 - 40) + 40, 2),
                    Weight = Math.Round(rand.NextDouble() * (50- 20) + 20, 2),
                    MidiChlorianCount = Math.Round(rand.NextDouble() * (500 - 100) + 100, 2),
                    Title = "Younglings",
                    Name = "Youngling",
                    Surname = i.ToString(),
                    LightSaber = new LightSaber
                    {
                        Id = Guid.NewGuid().ToString(),
                        Attack = 10,
                        Defense = 10,
                        Color = "Brown",
                        Type = LightSaberType.Training,
                        Length = 10,
                        Width = 1,
                        JediId = id,
                    },
                });
            }

            context.AddRange(data);
            context.SaveChanges();

        }
    }
}
