using System;

namespace Dominio
{
    using System.Collections.Generic;

    /// <summary>
    /// La interfaz clasificadora de Animales
    /// </summary>
    interface IClasificadorAnimales
    {
        /// <summary>
        /// El método clasifica los animales de acuerdo a ciertas reglas.
        /// </summary>
        /// <param name="nombreAnimal">
        /// El nombre del animal.
        /// </param>
        /// <returns>
        /// El <see cref="Animal"/>.
        /// </returns>
        Animal Clasificar(String nombreAnimal);

        /// <summary>
        /// Clasifica en lote los animales definidos en String.
        /// </summary>
        /// <param name="nombresAnimales">
        /// Los nombres animales.
        /// </param>
        /// <returns>
        /// Lista de Animales <see cref="List"/>.
        /// </returns>
        List<Animal> ClasificarEnLote(List<String> nombresAnimales);

        /// <summary>
        /// Filtra los bovinos a partir de una lista de animales.
        /// </summary>
        /// <param name="animales">
        /// Lista de animales.
        /// </param>
        /// <returns>
        /// Retorna una lista de Bovinos <see cref="List"/>.
        /// </returns>
        List<Bovino> FiltrarBovinos(List<Animal> animales);

        /// <summary>
        /// Filtra los equinos a partir de una lista de animales.
        /// </summary>
        /// <param name="animales">
        /// Lista de animales.
        /// </param>
        /// <returns>
        /// Retorna una lista de Equinos <see cref="List"/>.
        /// </returns>
        List<Equino> FiltrarEquinos(List<Animal> animales);
    }
}
