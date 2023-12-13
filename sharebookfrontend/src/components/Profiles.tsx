import React from "react";
import axios from "axios";
import Profile from "../models/Profile";

export default class Profiles extends React.Component {
  state = {
    profiles: [] as Profile[], // Explicitly initialize with an empty array of Profile type
  };

  componentDidMount() {
    axios
      .get<Profile[]>("https://localhost:7179/Profile/GetAll")
      .then((res) => {
        const profiles = res.data;
        this.setState({ profiles });
      })
      .catch((error) => {
        console.error("Error fetching profiles:", error);
      });
  }

  render() {
    return (
      <ul>
        {this.state.profiles.map((profile) => (
          <li key={profile.id}>
            ID: {profile.id}, Name: {profile.name}, Description:{" "}
            {profile.description}
          </li>
        ))}
      </ul>
    );
  }
}
