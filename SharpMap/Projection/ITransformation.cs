﻿using SharpMap.Geometries;

namespace SharpMap.Projection
{
    public interface ITransformation
    {
        int MapSRID { get; set; }
        Geometry Transform(int fromSRID, int toSRID, Geometry geometry);
        BoundingBox Transfrom(int fromSRID, int toSRID, BoundingBox boundingBox);
    }
}