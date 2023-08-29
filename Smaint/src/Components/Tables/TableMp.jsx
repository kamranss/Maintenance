import * as React from "react";
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";
import moment from "moment";

export default function TableMp({ thead = [], rows = [] }) {
  return (
    <TableContainer
      component={Paper}
      sx={{ borderTopLeftRadius: 0, borderTopRightRadius: 0 }}
    >
      <Table sx={{ minWidth: 650 }} aria-label="simple table">
        <TableHead>
          <TableRow>
            {thead?.map((th, key) => (
              <TableCell key={key}>{th}</TableCell>
            ))}
          </TableRow>
        </TableHead>
        <TableBody>
          {rows.map((row, key) => (
            <TableRow
              key={key}
              sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
            >
              <TableCell align="left">{row?.id}</TableCell>
              <TableCell align="left">{row?.Code}</TableCell>
              <TableCell align="left">{row?.Name || "-"}</TableCell>
              <TableCell align="left">{row?.description || "-"}</TableCell>
              <TableCell align="left">{row?.Status || "-"}</TableCell>
              <TableCell align="left">{row?.MetricType || "-"}</TableCell>
              <TableCell align="left">
                {moment(row?.createdDate).format("DD-MM-YYYY") || "-"}
              </TableCell>
              <TableCell align="left">
                {row?.equipments?.length > 0 ? row?.equipments : "-"}
              </TableCell>
              {/* <TableCell align="right">{row?.isActive}</TableCell> */}
              {/* <TableCell align="right">{row?.isDeleted}</TableCell> */}
              {/* <TableCell align="right">{row?.updatedDate}</TableCell> */}
              {/* <TableCell align="right">{row?.createdBy}</TableCell> */}
              {/* <TableCell align="right">{row?.modifiedBy}</TableCell> */}
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>
  );
}
