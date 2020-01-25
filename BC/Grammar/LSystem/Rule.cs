using System;

namespace BC.Grammar.LSystem
{
    public struct Rule : IEquatable<Rule>
    {
        /// <summary>
        /// The predecessor of this rule
        /// </summary>
        /// <value></value>
        public string Predecessor { get; }

        /// <summary>
        /// The sucessor of this rule
        /// </summary>
        /// <value></value>
        public string Successor { get; }

        /// <summary>
        /// Creates a new Rule value
        /// </summary>
        /// <param name="predecessor">the predecessor value of the Rule</param>
        /// <param name="successor">the successor value of the Rule</param>
        public Rule(string predecessor, string successor)
        {
            Predecessor = predecessor;
            Successor = successor;
        }

        public bool Equals(Rule other) =>
            this == other;

        public override int GetHashCode() =>
            HashCode.Combine(Predecessor, Successor);

        public override bool Equals(object obj) =>
            obj is Rule other &&
            this.Equals(other);

        public static bool operator ==(Rule lhs, Rule rhs) =>
            lhs.Predecessor.Equals(rhs.Predecessor) && lhs.Successor.Equals(rhs.Successor);

        public static bool operator !=(Rule lhs, Rule rhs) =>
            !lhs.Predecessor.Equals(rhs.Predecessor) || !lhs.Successor.Equals(rhs.Successor);
    }
}
