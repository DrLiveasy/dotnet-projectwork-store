﻿namespace Projectwork_Store.Models
{
    public class CarCategory
    {
        //car vuota per il form
        public Car Car { get; set; }

        //lista categories per la select
        public List<Category>? Categories { get; set; }

        //lista stickers per la select
        public List<Sticker>? Stickers { get; set; }

    }
}
