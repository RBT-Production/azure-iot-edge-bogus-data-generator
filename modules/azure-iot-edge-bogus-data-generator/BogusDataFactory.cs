// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Bogus;
using Bogus.DataSets;
using IoTEdgeBogusDataGenerator.Models;
using System.Collections.Generic;

namespace IoTEdgeBogusDataGenerator
{
    public class BogusDataFactory
    {


        public static Object CreateBogusData(int counter)
        {
            //Set the randomzier seed if you wish to generate repeatable data sets.
            Randomizer.Seed = new Random(counter);

            var vehicleData = new Faker<EspSystemData>()
                //Ensure all properties have rules. By default, StrictMode is false
                //Set a global policy by using Faker.DefaultStrictMode
                .StrictMode(true)
                //Id is deterministic
                .RuleFor(o => o.Id, f => counter)
                //Generate Random value for motor load
                .RuleFor(o => o.MotorLoad, f => f.Random.Number(80, 90));
            
            return vehicleData.Generate();
        }
    }
}