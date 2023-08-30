import * as React from "react";
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";
import moment from "moment";

// function createData(name, calories, fat, carbs, protein) {
//   return { name, calories, fat, carbs, protein };
// }

// const rows = [
//   createData("Frozen yoghurt", 159, 6.0, 24, 4.0),
//   createData("Ice cream sandwich", 237, 9.0, 37, 4.3),
//   createData("Eclair", 262, 16.0, 24, 6.0),
//   createData("Cupcake", 305, 3.7, 67, 4.3),
//   createData("Gingerbread", 356, 16.0, 49, 3.9),
// ];

export default function TableEquipment({ thead = [], rows = [], onRowClick }) {
  return (
    <TableContainer
      component={Paper}
      sx={{ borderTopLeftRadius: 0, borderTopRightRadius: 0 }}
    >
      <Table sx={{ minWidth: 650 }} aria-label="simple table">
        <TableHead>
          <TableRow>
            {/* <TableCell>Dessert (100g serving)</TableCell>
            <TableCell align="right">Calories</TableCell>
            <TableCell align="right">Fat&nbsp;(g)</TableCell>
            <TableCell align="right">Carbs&nbsp;(g)</TableCell>
            <TableCell align="right">Protein&nbsp;(g)</TableCell> */}
            {thead?.map((th, key) => (
              <TableCell key={key}>{th}</TableCell>
            ))}
          </TableRow>
        </TableHead>
        <TableBody>
          {rows.map((row, key) => {
            const statusClass =
              row.status === "ACTIVE"
                ? "row-active"
                : row.status === "INACTIVE"
                ? "row-inactive"
                : row.status === "REPAIR"
                ? "row-repair"
                : row.status === "INUSE"
                ? "row-inuse"
                : "";

            return (
              <TableRow
                key={key}
                onClick={() => onRowClick(row.id)}
                // className={`row ${statusClass}`} // Add 'row' class and status class
                sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
              >
                <TableCell align="left">
                  {/* {" "} */}
                  {console.log("mpTime:", row.mpTime)}
                  {console.log(
                    "Condition:",
                    row.mptime != true && row.mptime != null
                  )}
                  {row.mpTime !== true && row.mpTime !== null ? (
                    <i className="far fa-clock"></i> // Clock icon for incomplete
                  ) : (
                    <i className="fa-solid fa-check"></i>
                  )}
                </TableCell>
                <TableCell align="left">{row?.id}</TableCell>

                <TableCell align="left">{row?.name}</TableCell>
                <TableCell align="left">{row?.description || "-"}</TableCell>
                <TableCell align="left">{row?.operationSite || "-"}</TableCell>
                <TableCell align="left">{row?.productionYear || "-"}</TableCell>
                <TableCell align="left">{row?.serialNumber || "-"}</TableCell>
                <TableCell align="left">{row?.type || "-"}</TableCell>
                <TableCell
                  className={`${
                    row.status === "ACTIVE"
                      ? "row-active"
                      : row.status === "INACTIVE"
                      ? "row-inactive"
                      : row.status === "REPAIR"
                      ? "row-repair"
                      : row.status === "INUSE"
                      ? "row-inuse"
                      : ""
                  }`}
                  align="left"
                >
                  {row?.status || "-"}
                </TableCell>
                <TableCell align="left">{row?.usageLocation || "-"}</TableCell>
                <TableCell align="left">{row?.department || "-"}</TableCell>
                <TableCell align="left">{row?.manufacture || "-"}</TableCell>

                <TableCell align="left">{row?.model || "-"}</TableCell>
                <TableCell align="left">
                  {moment(row?.lastMaintenace).format("DD-MM-YYYY") || "-"}
                </TableCell>
                <TableCell align="left">{row?.currentValue || "-"}</TableCell>
                <TableCell align="left">
                  {row?.equipments?.length > 0 ? row?.equipments : "-"}
                </TableCell>
                {/* <TableCell align="left">
                {row?.equipments?.length > 0 ? row?.equipments : "-"}
              </TableCell> */}
                {/* <TableCell align="right">{row?.isActive}</TableCell> */}
                {/* <TableCell align="right">{row?.isDeleted}</TableCell> */}
                {/* <TableCell align="right">{row?.updatedDate}</TableCell> */}
                {/* <TableCell align="right">{row?.createdBy}</TableCell> */}
                {/* <TableCell align="right">{row?.modifiedBy}</TableCell> */}
              </TableRow>
            );
          })}
        </TableBody>
      </Table>
    </TableContainer>
  );
}
