import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { MaterialReactTable } from 'material-react-table';

const GameTable = () => {
  const [games, setGames] = useState([]);

  useEffect(() => {
    // liaison avec l'api pour récup les données
    axios.get('http://localhost:5151/api/games')
      .then(response => {
        setGames(response.data);
      })
      .catch(error => {
        console.error('Erreur lors de la récupération des jeux :', error);
      });
  }, []);

  // données récupérées et affichage dans le tableau
  const columns = [
    { accessorKey: 'name', header: 'Nom du Jeu'},
    { accessorKey: 'editor', header: 'Éditeur' },
    { accessorKey: 'starRating.rate', header: 'Note' },
    { accessorKey: 'platforms', header: 'Plateformes', Cell: ({ cell }) => cell.getValue().join(', ') },
  ];

  return (
    <MaterialReactTable
      columns={columns}
      data={games}
      enableSorting
      enableColumnFilters
    />
  );
};

export default GameTable;
