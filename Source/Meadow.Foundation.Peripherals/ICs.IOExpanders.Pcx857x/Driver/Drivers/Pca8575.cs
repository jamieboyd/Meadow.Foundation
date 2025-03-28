﻿using Meadow.Hardware;

namespace Meadow.Foundation.ICs.IOExpanders
{
    /// <summary>
    /// Represents the Pca8575 8-bit I/O I2C expander
    /// </summary>
    public class Pca8575 : Pcx8575
    {
        /// <summary>
        /// Initializes a new instance of the Pca8575 device
        /// </summary>
        /// <param name="i2cBus">The I2C bus the peripheral is connected to</param>
        /// <param name="address">The I2C bus address of the peripheral</param>
        /// <param name="interruptPin">The interrupt pin</param>
        public Pca8575(II2cBus i2cBus, byte address, IPin? interruptPin)
            : base(i2cBus, address, interruptPin)
        { }

        /// <summary>
        /// Initializes a new instance of the Pca8575 device
        /// </summary>
        /// <param name="i2cBus">The I2C bus the peripheral is connected to</param>
        /// <param name="address">The I2C bus address of the peripheral</param>
        /// <param name="interruptPort">The interrupt port</param>
        public Pca8575(II2cBus i2cBus, byte address, IDigitalInterruptPort? interruptPort = default)
            : base(i2cBus, address, interruptPort)
        { }

        /// <summary>
        /// Helper method to get address from address pin configuration
        /// </summary>
        /// <param name="pinA0">State of A0 address pin - true if high</param>
        /// <param name="pinA1">State of A1 address pin - true if high</param>
        /// <param name="pinA2">State of A2 address pin - true if high</param>
        /// <returns>The device address</returns>
        public static byte GetAddressForPins(bool pinA0, bool pinA1, bool pinA2)
            => GetAddressFromPins(pinA0, pinA1, pinA2, false);
    }
}