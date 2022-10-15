﻿using EasyData.EntityFrameworkCore;

namespace EasyDataExample.Models;

[MetaEntity(DisplayName = "Материал", DisplayNamePlural = "Материалы", Description = "Выборка материалов")]
public class Material
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    
    public int EstimateId { get; set; }
    public virtual Estimate Estimate { get; set; }
}