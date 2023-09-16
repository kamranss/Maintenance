// MaintenancePlanTable.js

import React, { useState } from "react";
import {
  Button,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Paper,
  TablePagination,
} from "@mui/material";

const TableEquipmentMp = ({ maintenancePlans }) => {
  const [page, setPage] = useState(0);
  const [rowsPerPage, setRowsPerPage] = useState(5);

  const handleChangePage = (event, newPage) => {
    setPage(newPage);
  };

  const handleChangeRowsPerPage = (event) => {
    setRowsPerPage(parseInt(event.target.value, 10));
    setPage(0);
  };

  const handleButtonClick = (row) => {
    // Implement your logic to send a request to another table
    console.log("Button clicked for row:", row);
    // You can send a request or perform any action here
  };

  return (
    <>
      <TableContainer component={Paper}>
        <Table>
          <TableHead>
            <TableRow>
              <TableCell>Mp Time</TableCell>
              <TableCell>ID</TableCell>
              <TableCell>Code</TableCell>
              <TableCell>Name</TableCell>
              <TableCell>Description</TableCell>
              <TableCell>sequenceValue</TableCell>
              <TableCell>Finish Mp</TableCell>
              {/* Add other table headers */}
            </TableRow>
          </TableHead>
          <TableBody>
            {maintenancePlans
              .slice(page * rowsPerPage, page * rowsPerPage + rowsPerPage)
              .map((row) => (
                <TableRow key={row.id}>
                  <TableCell align="left">
                    {row.maintenanceSettingsList &&
                    row.maintenanceSettingsList[0] ? (
                      row.maintenanceSettingsList[0].mpCompleted !== true &&
                      row.maintenanceSettingsList[0].mpCompleted !== null ? (
                        <i className="far fa-clock"></i> // Clock icon for incomplete
                      ) : (
                        <i className="fa-solid fa-check"></i>
                      )
                    ) : (
                      // Handle the case where maintenanceSettingsList is null
                      <i className="fa-solid fa-check"></i>
                    )}
                  </TableCell>
                  <TableCell>{row.id}</TableCell>
                  <TableCell>{row.code}</TableCell>
                  <TableCell>{row.name}</TableCell>
                  <TableCell>{row.description}</TableCell>
                  <TableCell>
                    {row.maintenanceSettingsList &&
                    row.maintenanceSettingsList.length > 0
                      ? row.maintenanceSettingsList[0]?.sequenceValue ?? ""
                      : ""}
                  </TableCell>
                  <TableCell>
                    {/* Add a button that calls handleButtonClick with the current row */}
                    <Button
                      variant="contained"
                      style={{ fontSize: "12px", padding: "2px 5px" }}
                      color="primary"
                      onClick={() => handleButtonClick(row)}
                    >
                      Complete Mp
                    </Button>
                  </TableCell>
                </TableRow>
              ))}
          </TableBody>
        </Table>
      </TableContainer>
      <TablePagination
        rowsPerPageOptions={[5, 10, 25]}
        component="div"
        count={maintenancePlans.length}
        rowsPerPage={rowsPerPage}
        page={page}
        onPageChange={handleChangePage}
        onRowsPerPageChange={handleChangeRowsPerPage}
      />
    </>
  );
};

export default TableEquipmentMp;
