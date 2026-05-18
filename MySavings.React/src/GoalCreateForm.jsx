import { useState } from "react";
import { api } from "./services/api";

export default function GoalCreateForm() {
  const [form, setForm] = useState({
    title: "",
    targetAmount: "",
  });
  const [error, setError] = useState("");

  const handleChange = (e) => {
    setForm({
      ...form,
      [e.target.name]: e.target.value,
    });
    setError("");
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    try {
      await api.post("/goals", {
        title: form.title,
        targetAmount: Number(form.targetAmount),
      });

      alert("Goal created successfully!");
      setForm({ title: "", targetAmount: "" });
    } catch (err) {
      console.error("Error details:", err.response?.data || err.message);
      setError(err.response?.data?.message || "Error creating goal");
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <h2>Create Savings Goal</h2>

      <input
        name="title"
        placeholder="Goal title"
        value={form.title}
        onChange={handleChange}
        required
      />

      <input
        name="targetAmount"
        type="number"
        placeholder="Target amount"
        value={form.targetAmount}
        onChange={handleChange}
        required
        min="0.01"
        step="0.01"
      />

      <button type="submit">Create</button>
      {error && <p style={{ color: "red" }}>{error}</p>}
    </form>
  );
}
