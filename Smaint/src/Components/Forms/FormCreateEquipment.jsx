import React, { useEffect, useState } from "react";
import axios from "axios";
import Swal from "sweetalert2";
import withReactContent from "sweetalert2-react-content";
// import FormInputYear from "../FormFields/FormInputYear";
// import { FormControl, FormGroup, FormLabel } from "react-bootstrap";

// import { FormControl, FormGroup, FormLabel, Button } from "@mui/material";
// import { makeStyles } from "@mui/styles";
// import "bootstrap/dist/css/bootstrap.min.css";
import {
  FormControl,
  FormGroup,
  FormLabel,
  Button,
  TextField,
  Select,
  MenuItem,
  // InputLabel,
  styled,
  // ThemeProvider,
  createTheme,
  Autocomplete,
  debounce,
  Popper,
} from "@mui/material";
// import { styled } from "@mui/material/styles";

const FormCreateEquipment = () => {
  // const [enteredName, setEnteredName] = useState("");

  const [models, setModels] = useState([]); // State to hold fetched models
  const [selectedModel, setSelectedModel] = useState(null);
  const [selectedModelId, setSelectedModelId] = useState(""); // State to hold selected model ID
  const [searchQuery, setSearchQuery] = useState(""); // State to hold search query

  const [Types, setTypes] = useState([]);
  const [selectedType, setSelectedType] = useState(null);
  const [selectedTypelId, setSelectedTypeId] = useState(""); // State to hold selected model ID
  const [searchQueryfortypes, setSearchQueryfortypes] = useState(""); // State to hold search query

  const [Departments, setDepartments] = useState([]);
  const [selectedDepartments, setSelectedDepartments] = useState(null);
  const [selectedDepartmentsId, setSelectedDepartmentsId] = useState(""); // State to hold selected model ID
  const [searchQueryforDepartments, setSearchQueryforDepartments] =
    useState(""); // State to hold search query

  const [UsageLocations, setUsageLocations] = useState([]);
  const [selectedUsageLocations, setSelectedUsageLocations] = useState(null);
  const [selectedUsageLocationsId, setSelectedUsageLocationsId] = useState(""); // State to hold selected model ID
  const [searchQueryforUsageLocations, setSearchQueryforUsageLocations] =
    useState("");

  const [Manufactures, setManufactures] = useState([]);
  const [selectedManufacture, setSelectedManufactures] = useState(null);
  const [selectedManufacturesId, setSelectedManufactureId] = useState(""); // State to hold selected model ID
  const [searchQueryforManufactures, setSearchQueryforManufactures] =
    useState("");

  const [OperationSite, setOperationSite] = useState([]);
  const [selectedOperationSite, setSelectedOperationSite] = useState(null);
  const [selectedOperationSiteId, setSelectedOperationSiteId] = useState(""); // State to hold selected model ID
  const [searchQueryforOperationSite, setSearchQueryforOperationSite] =
    useState("");

  const MySwal = withReactContent(Swal);
  const [validationErrors, setValidationErrors] = useState({});
  const [isSubmitted, setIsSubmitted] = useState(false);

  const [formData, setFormData] = useState({}); // State to hold form data

  // const [filteredModels, setFilteredModels] = useState([]); // State to hold filtered models
  const theme = createTheme();

  // const CustomPopper = React.forwardRef(function CustomPopper(props, ref) {
  //   return (
  //     <Popper
  //       {...props}
  //       placement="bottom-start" // Adjust the placement as needed
  //       modifiers={[
  //         {
  //           name: "offset",
  //           options: {
  //             offset: [0, 8], // Adjust the offset to position the dropdown
  //           },
  //         },
  //       ]}
  //       ref={ref}
  //     />
  //   );
  // });

  // useEffect(() => {
  //   // Fetch models from the API when the component mounts
  //   fetchModels(searchQuery);
  // }, [searchQuery]);

  const useStyles = styled((theme) => ({
    select: {
      width: "100%", // Adjust the width as needed
      "& .MuiSelect-select.MuiSelect-select": {
        paddingBottom: theme.spacing(1), // Adds spacing below the dropdown icon
      },
    },
  }));

  const fetchModels = async (name) => {
    try {
      const params = new URLSearchParams({
        name: name, // Use the search query as the 'name' parameter
      });

      const url = `https://localhost:7066/api/Model/DropDown?${params}`;
      const response = await axios.get(url);
      console.log("API response:", response.data); // Log the API response

      if (response.data && Array.isArray(response.data)) {
        console.log("Fetched models:", response.data); // Log the fetched models
        setModels(response.data);
      } else {
        console.error(
          "API response does not contain an array of models:",
          response.data
        );
      }
    } catch (error) {
      console.error("Error:", error);
    }
  };

  const fetchTypes = async (name) => {
    try {
      const params = new URLSearchParams({
        name: name, // Use the search query as the 'name' parameter
      });

      const url = `https://localhost:7066/api/EquipmentType/DropDown?${params}`;
      const response = await axios.get(url);
      console.log("API response:", response.data); // Log the API response

      if (response.data && Array.isArray(response.data)) {
        console.log("Fetched models:", response.data); // Log the fetched models
        setTypes(response.data);
      } else {
        console.error(
          "API response does not contain an array of models:",
          response.data
        );
      }
    } catch (error) {
      console.error("Error:", error);
    }
  };

  const fetchDepartments = async (name) => {
    try {
      const params = new URLSearchParams({
        name: name, // Use the search query as the 'name' parameter
      });

      const url = `https://localhost:7066/api/Department/DropDown?${params}`;
      const response = await axios.get(url);
      console.log("API response:", response.data); // Log the API response

      if (response.data && Array.isArray(response.data)) {
        console.log("Fetched models:", response.data); // Log the fetched models
        setDepartments(response.data);
      } else {
        console.error(
          "API response does not contain an array of models:",
          response.data
        );
      }
    } catch (error) {
      console.error("Error:", error);
    }
  };

  const fetchManufacture = async (name) => {
    try {
      const params = new URLSearchParams({
        name: name, // Use the search query as the 'name' parameter
      });

      const url = `https://localhost:7066/api/Manufacture/DropDown?${params}`;
      const response = await axios.get(url);
      console.log("API response:", response.data); // Log the API response

      if (response.data && Array.isArray(response.data)) {
        console.log("Fetched models:", response.data); // Log the fetched models
        setManufactures(response.data);
      } else {
        console.error(
          "API response does not contain an array of models:",
          response.data
        );
      }
    } catch (error) {
      console.error("Error:", error);
    }
  };

  const fetchOperationSites = async (name) => {
    try {
      const params = new URLSearchParams({
        name: name, // Use the search query as the 'name' parameter
      });

      const url = `https://localhost:7066/api/OperationSite/DropDown?${params}`;
      const response = await axios.get(url);
      console.log("API response:", response.data); // Log the API response

      if (response.data && Array.isArray(response.data)) {
        console.log("Fetched models:", response.data); // Log the fetched models
        setOperationSite(response.data);
      } else {
        console.error(
          "API response does not contain an array of models:",
          response.data
        );
      }
    } catch (error) {
      console.error("Error:", error);
    }
  };

  const fetchUsageLoacation = async (name) => {
    try {
      const params = new URLSearchParams({
        name: name, // Use the search query as the 'name' parameter
      });

      const url = `https://localhost:7066/api/Constants/Location?${params}`;
      const response = await axios.get(url);
      console.log("API response:", response.data); // Log the API response

      if (response.data && Array.isArray(response.data)) {
        console.log("Fetched models:", response.data); // Log the fetched models
        setUsageLocations(response.data);
      } else {
        console.error(
          "API response does not contain an array of models:",
          response.data
        );
      }
    } catch (error) {
      console.error("Error:", error);
    }
  }; // this is enum should be fixed

  const fetchModelsDebounced = debounce(fetchModels, 300);
  useEffect(() => {
    // Fetch models from the API when the component mounts or searchQuery changes
    fetchModels(searchQuery);
  }, [searchQuery]);

  const fetchTypesDebounced = debounce(fetchTypes, 300);
  useEffect(() => {
    fetchTypes(searchQueryfortypes);
  }, [searchQueryfortypes]);

  const fetchDepartmentsDebounced = debounce(fetchDepartments, 300);
  useEffect(() => {
    fetchDepartments(searchQueryforDepartments);
  }, [searchQueryforDepartments]);

  const fetchManufactureDebounced = debounce(fetchManufacture, 300);
  useEffect(() => {
    fetchManufacture(searchQueryforManufactures);
  }, [searchQueryforManufactures]);

  const fetchOperationSitesDebounced = debounce(fetchOperationSites, 300);
  useEffect(() => {
    fetchManufacture(searchQueryforOperationSite);
  }, [searchQueryforOperationSite]);

  const fetchUsageLocationDebounced = debounce(fetchUsageLoacation, 300);
  useEffect(() => {
    fetchUsageLoacation(searchQueryforUsageLocations);
  }, [searchQueryforUsageLocations]);

  // const StyledSelect = styled(Select)({
  //   width: "100%",
  //   marginTop: theme.spacing(1),
  //   "& .MuiSelect-select.MuiSelect-select": {
  //     paddingBottom: theme.spacing(1),
  //   },
  // });
  // const StyledMenuItem = styled(MenuItem)({
  //   width: "20%",
  //   // Match the width of the StyledSelect
  // });

  // const submitForm = async (e) => {
  //   e.preventDefault();

  //   try {
  //     const response = await fetch(
  //       "https://localhost:7066/api/Equipment/NewEquipment",
  //       {
  //         method: "POST",
  //         headers: {
  //           "Content-Type": "application/json",
  //         },
  //         body: JSON.stringify({
  //           Name: formData.Name,
  //           UnitNumber: formData.UnitNumber,
  //           Description: formData.Description,
  //           Identification: formData.Identification,
  //           OperationSiteid: formData.OperationSiteid,
  //           ManufactureId: formData.ManufactureId,
  //           ProductionYear: formData.ProductionYear,
  //           SeriaNumber: formData.SeriaNumber,
  //           Capacity: formData.Capacity,
  //           EquipmentTypeId: selectedType ? selectedType.id : null,
  //           UsageLocation: selectedUsageLocations
  //             ? selectedUsageLocations.label
  //             : null,
  //           DepartmentId: selectedDepartments ? selectedDepartments.id : null,
  //           ModelId: selectedModel ? selectedModel.id : null,
  //           Image: formData.Image, // You'll need to handle file uploads properly
  //           LastMaintenaceDate: formData.LastMaintenaceDate,
  //           CurrentValue: formData.CurrentValue,
  //         }),
  //       }
  //     );

  //     if (response.ok) {
  //       console.log("Equipment created successfully.");
  //     } else {
  //       const errorMessage = await response.text();
  //       console.error("Error:", errorMessage);
  //     }
  //   } catch (error) {
  //     console.error("Error:", error);
  //   }
  // };

  const submitForm = async (e) => {
    e.preventDefault();

    try {
      const formData = new FormData(); // Create a new FormData object

      formData.append("Name", formData.Name || "");
      formData.append("UnitNumber", formData.UnitNumber || "");
      formData.append("Description", formData.Description || "");
      formData.append("Identification", formData.Identification || "");
      formData.append("OperationSiteid", formData.OperationSiteid || "");
      formData.append("ManufactureId", formData.ManufactureId || "");
      formData.append("ProductionYear", formData.ProductionYear || "");
      formData.append("SeriaNumber", formData.SeriaNumber || "");
      formData.append("Capacity", formData.Capacity || "");
      formData.append("EquipmentTypeId", selectedType ? selectedType.id : "");
      // formData.append(
      //   "UsageLocation",
      //   selectedUsageLocations ? selectedUsageLocations.label : ""
      // );
      formData.append(
        "DepartmentId",
        selectedDepartments ? selectedDepartments.id : ""
      );
      formData.append("ModelId", selectedModel ? selectedModel.id : "");
      if (formData.Image instanceof File) {
        formData.append("Image", formData.Image);
      }
      console.log(formData.Image);
      formData.append("LastMaintenaceDate", formData.LastMaintenaceDate || "");
      formData.append("CurrentValue", formData.CurrentValue || "");
      console.log(selectedUsageLocationsId);
      console.log(selectedUsageLocations);
      formData.append(
        "UsageLocation",
        selectedUsageLocations ? selectedUsageLocations : ""
      );

      const response = await fetch(
        "https://localhost:7066/api/Equipment/NewEquipment",
        {
          method: "POST",
          body: formData, // Use the FormData object as the request body
        }
      );

      if (response.ok) {
        MySwal.fire({
          icon: "success",
          title: "Success!",
          text: "Equipment created successfully.",
        }).then(() => {
          window.location.href = "/EquipmentPage";
          setIsSubmitted(true);
        });
        console.log("Equipment created successfully.");
        setValidationErrors({});
      } else if (response.status === 400) {
        // Bad request with validation errors
        const errorData = await response.json();
        console.log("Validation errors:", errorData);

        // Update the state with the validation errors
        setValidationErrors(errorData.errors);
      } else {
        const errorMessage = await response.text();
        console.error("Error:", errorMessage);
      }
    } catch (error) {
      console.error("Error:", error);
    }
  };

  const handleInputChange = (fieldName, value) => {
    // Reset validation error for the specific field when the user starts typing
    setValidationErrors((prevErrors) => ({
      ...prevErrors,
      [fieldName]: [],
    }));

    // Update formData state
    setFormData((prevData) => ({
      ...prevData,
      [fieldName]: value,
    }));
  };
  const classes = useStyles();

  return (
    <>
      <form className="FormMain" onSubmit={submitForm}>
        <h2 className="heading">Create Equipment</h2>
        <div className="FormContainer">
          <div className="FormLeftSide">
            {/* <h2>Identification</h2> */}
            <div>
              <FormGroup className="mb-3">
                <FormLabel>Equipment Name</FormLabel>
                <TextField
                  type="text"
                  name="Name"
                  onChange={(e) => handleInputChange("Name", e.target.value)}
                />
                {validationErrors.Name && (
                  <span className="validation-error">
                    {validationErrors.Name[0]}
                  </span>
                )}
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Unit Number</FormLabel>
                <TextField
                  type="number"
                  name="UnitNumber"
                  onChange={(e) =>
                    handleInputChange("UnitNumber", e.target.value)
                  }
                />
                {validationErrors.UnitNumber && (
                  <span className="validation-error">
                    {validationErrors.UnitNumber[0]}
                  </span>
                )}
              </FormGroup>

              <FormGroup className="mb-3">
                <FormLabel>Description</FormLabel>
                <TextField
                  type="text"
                  name="Description"
                  onChange={(e) =>
                    handleInputChange("Description", e.target.value)
                  }
                />
                {validationErrors.Description && (
                  <span className="validation-error">
                    {validationErrors.Description[0]}
                  </span>
                )}
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Identification</FormLabel>
                <TextField type="number" name="Identification" />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>OperationSite</FormLabel>
                <TextField type="number" name="OperationSiteid" />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Manufacture</FormLabel>
                <Autocomplete
                  id="manufacture-autocomplete"
                  options={Manufactures}
                  getOptionLabel={(manufacture) => manufacture.name}
                  value={selectedManufacture} // Bind selectedModelId to the Autocomplete value
                  onChange={(event, newValue) => {
                    setSelectedDepartments(newValue); // Update selectedModel when a model is selected
                  }}
                  onInputChange={(event, newInputValue) => {
                    setSearchQueryforManufactures(newInputValue); // Update searchQuery as input changes
                  }}
                  inputValue={searchQueryforManufactures}
                  renderInput={(params) => (
                    <TextField
                      {...params}
                      label="Search or Select Manufactures"
                      variant="outlined"
                    />
                  )}
                  renderOption={(props, option) => (
                    <li {...props}>{option.name}</li>
                  )}
                  PopperProps={{
                    placement: "bottom-start", // Adjust the placement as needed
                    modifiers: [
                      {
                        name: "offset",
                        options: {
                          offset: [0, 8], // Adjust the offset to position the dropdown
                        },
                      },
                    ],
                  }}
                />
              </FormGroup>
            </div>
            <div>
              <FormGroup className="mb-3">
                <FormLabel>ProductionYear</FormLabel>
                <TextField type="number" name="ProductionYear" />
                {validationErrors.ProductionYear && (
                  <span className="validation-error">
                    {validationErrors.ProductionYear[0]}
                  </span>
                )}
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>SerialNumber</FormLabel>
                <TextField type="text" name="SerialNumber" />
                {validationErrors.SeriaNumber && (
                  <span className="validation-error">
                    {validationErrors.SeriaNumber[0]}
                  </span>
                )}
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Capacity</FormLabel>
                <TextField type="text" name="Capacity" />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Type</FormLabel>
                <Autocomplete
                  id="type-autocomplete"
                  options={Types}
                  getOptionLabel={(type) => type.name}
                  value={selectedType} // Bind selectedModelId to the Autocomplete value
                  onChange={(event, newValue) => {
                    setSelectedType(newValue); // Update selectedModel when a model is selected
                  }}
                  onInputChange={(event, newInputValue) => {
                    setSearchQueryfortypes(newInputValue); // Update searchQuery as input changes
                  }}
                  inputValue={searchQueryfortypes}
                  renderInput={(params) => (
                    <TextField
                      {...params}
                      label="Search or Select Model"
                      variant="outlined"
                    />
                  )}
                  renderOption={(props, option) => (
                    <li {...props}>{option.name}</li>
                  )}
                  PopperProps={{
                    placement: "bottom-start", // Adjust the placement as needed
                    modifiers: [
                      {
                        name: "offset",
                        options: {
                          offset: [0, 8], // Adjust the offset to position the dropdown
                        },
                      },
                    ],
                  }}
                />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Model</FormLabel>
                <Autocomplete
                  id="model-autocomplete"
                  options={models}
                  getOptionLabel={(model) => model.name}
                  value={selectedModel} // Bind selectedModelId to the Autocomplete value
                  onChange={(event, newValue) => {
                    setSelectedModel(newValue); // Update selectedModel when a model is selected
                  }}
                  onInputChange={(event, newInputValue) => {
                    setSearchQuery(newInputValue); // Update searchQuery as input changes
                  }}
                  inputValue={searchQuery}
                  renderInput={(params) => (
                    <TextField
                      {...params}
                      label="Search or Select Model"
                      variant="outlined"
                    />
                  )}
                  renderOption={(props, option) => (
                    <li {...props}>{option.name}</li>
                  )}
                  PopperProps={{
                    placement: "bottom-start", // Adjust the placement as needed
                    modifiers: [
                      {
                        name: "offset",
                        options: {
                          offset: [0, 8], // Adjust the offset to position the dropdown
                        },
                      },
                    ],
                  }}
                />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Image</FormLabel>
                <TextField type="file" name="Image" accept="image/*" />
              </FormGroup>
            </div>
          </div>
          <div className="FormRightSide">
            <h2>Pm Trucking</h2>
            <FormGroup className="mb-3">
              <FormLabel>Department</FormLabel>
              <Autocomplete
                id="department-autocomplete"
                options={Departments}
                getOptionLabel={(Department) => Department.name}
                value={selectedDepartments} // Bind selectedModelId to the Autocomplete value
                onChange={(event, newValue) => {
                  setSelectedDepartments(newValue); // Update selectedModel when a model is selected
                }}
                onInputChange={(event, newInputValue) => {
                  setSearchQueryforDepartments(newInputValue); // Update searchQuery as input changes
                }}
                inputValue={searchQueryforDepartments}
                renderInput={(params) => (
                  <TextField
                    {...params}
                    label="Search or Select Departments"
                    variant="outlined"
                  />
                )}
                renderOption={(props, option) => (
                  <li {...props}>{option.name}</li>
                )}
                PopperProps={{
                  placement: "bottom-start", // Adjust the placement as needed
                  modifiers: [
                    {
                      name: "offset",
                      options: {
                        offset: [0, 8], // Adjust the offset to position the dropdown
                      },
                    },
                  ],
                }}
              />
            </FormGroup>
            <FormGroup className="mb-3">
              <FormLabel>LastMaintenaceDate</FormLabel>
              <TextField type="date" name="LastMaintenaceDate" />
            </FormGroup>
            <FormGroup className="mb-3">
              <FormLabel>CurrentValue</FormLabel>
              <TextField type="number" name="CurrentValue" />
            </FormGroup>
            <FormGroup className="mb-3">
              <FormLabel>UsageLocation</FormLabel>
              <Autocomplete
                id="usageLocation-autocomplete"
                options={UsageLocations}
                // getOptionLabel={(usageLocation) => usageLocation}
                value={selectedUsageLocations} // Bind selectedModelId to the Autocomplete value
                onChange={(event, newValue) => {
                  setSelectedUsageLocations(newValue); // Update selectedModel when a model is selected
                }}
                onInputChange={(event, newInputValue) => {
                  setSearchQueryforUsageLocations(newInputValue); // Update searchQuery as input changes
                }}
                inputValue={searchQueryforUsageLocations}
                renderInput={(params) => (
                  <TextField
                    {...params}
                    label="Search or Select Departments"
                    variant="outlined"
                  />
                )}
                renderOption={(props, option) => (
                  <li {...props}>{option.label}</li>
                )}
                PopperProps={{
                  placement: "bottom-start",
                  modifiers: [
                    {
                      name: "offset",
                      options: {
                        offset: [0, 8],
                      },
                    },
                    {
                      name: "flip",
                      enabled: true,
                      options: {
                        flipVariations: true,
                        altBoundary: true,
                        boundary: "viewport",
                      },
                    },
                  ],
                  style: { zIndex: 1000 }, // Adjust the z-index value as needed
                }}
              />
            </FormGroup>
          </div>
        </div>
        <Button type="submit" variant="contained" color="primary">
          Submit
        </Button>
      </form>
    </>
  );
};

export default FormCreateEquipment;
